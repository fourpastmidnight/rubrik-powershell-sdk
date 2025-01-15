﻿using System;
using System.Linq;
using RubrikSecurityCloud.PowerShell.Models;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using System.Management.Automation;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.Client;
using RubrikSecurityCloud;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Private
{
	public class RscTypeInitializer
	{

        private static bool IsNullableEnum(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.IsGenericType &&
                propertyInfo.PropertyType.GetGenericTypeDefinition() ==
                typeof(Nullable<>))
            {
                var underlyingType = Nullable.GetUnderlyingType(propertyInfo.PropertyType);
                return underlyingType.IsEnum;
            }
            return false;
        }

        private static System.Type GetNullableUnderlyingType(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.IsGenericType &&
                propertyInfo.PropertyType.GetGenericTypeDefinition() ==
                typeof(Nullable<>))
            {
                var underlyingType = Nullable.GetUnderlyingType(propertyInfo.PropertyType);
                return underlyingType;
            }
            else return propertyInfo.PropertyType;
        }

        /// <summary>
        /// Get a list of all RSC schema types whose names contain a given string.
        /// </summary>
        /// <param name="nameFilter">string to match, case insensitive</param>
        /// <param name="interfaces">if true, return interfaces; if false return classes</param>
        public static List<RscTypeSummary> GetAllTypeNames(
               string nameFilter = null,
               bool interfaces = false)
        {
            List<RscTypeSummary> types = new List<RscTypeSummary>();
            System.Type baseType = typeof(BaseType);
            System.Type inputInterface = typeof(IInput); // For input types
            System.Type fieldSpecInterface = typeof(IFieldSpec);
            var assembly = Assembly.Load("RubrikSecurityCloud.Schema");
            if (assembly == null)
            {
                throw new Exception(
                    "Unable to load RubrikSecurityCloud.Schema");
            }
            var allTypes = assembly.GetTypes();
            foreach (var type in allTypes)
            {
                if (type.Namespace != "RubrikSecurityCloud.Types")
                {
                    continue;
                }
                if (nameFilter != null
                    && !type.Name.ToLower().Contains(nameFilter.ToLower()))
                {
                    continue;
                }
                // Add output types (derived from BaseType)
                if (!interfaces && type.IsClass && type.IsSubclassOf(baseType))
                {
                    types.Add(new RscTypeSummary { Name = type.Name });
                }
                // Add input types (implementing IInput)
                else if (!interfaces && type.IsClass && inputInterface.IsAssignableFrom(type))
                {
                    types.Add(new RscTypeSummary { Name = type.Name });
                }
                // Add interfaces if requested
                else if (interfaces && type.IsInterface && fieldSpecInterface.IsAssignableFrom(type))
                {
                    types.Add(new RscTypeSummary { Name = type.Name });
                }
            }

            return types.OrderBy(type => type.Name).ToList();
        }

        /// <summary>
        /// Get an RSC schema type by name.
        /// </summary>
        public static System.Type GetTypeByName(string name)
        {
            var assembly = Assembly.Load("RubrikSecurityCloud.Schema");

            if (assembly != null)
            {
                var type = assembly.GetType("RubrikSecurityCloud.Types." + name, false, true);
                return type;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Return an instance of an input, with fields contained in
        /// inputFields initialized to non-null values.
        /// </summary>
        /// <param name="inputTypeName"></param>
        /// <param name="providedInputFields"></param>
        /// <returns>object</returns>
        /// <exception cref="Exception"></exception>
        public static object InitializeInputWithSelectedFields(
            string inputTypeName,
            Hashtable providedInputFields
        ){
            System.Type inputType = GetTypeByName(inputTypeName);

            if (inputType == null) {
                throw new Exception(
                    String.Format("No type found matching {0}", inputTypeName)
                );
            }

            object inputInstance = Activator.CreateInstance(inputType);
            foreach (DictionaryEntry inputField in providedInputFields) {
                string fieldName = "";
                object fieldValue = null;

                try {
                    fieldName = (string) inputField.Key;
                    fieldValue = inputField.Value;
                }
                catch (InvalidCastException e) {
                    throw new Exception(
                        String.Format(
                            "Input field {0} should be a string: {1}",
                            fieldName,
                            e
                        )
                    );
                }

                PropertyInfo inputTypeField =
                    inputInstance
                        .GetType()
                        .GetProperty(
                            fieldName,
                            BindingFlags.IgnoreCase |
                            BindingFlags.Instance |
                            BindingFlags.Public
                        );

                if (inputTypeField == null) {
                    throw new Exception(
                        String.Format(
                            "Input field {0} does not exist in {1}",
                            fieldName,
                            inputTypeName
                        )
                    );
                }

                try {
                    // non-scalar values in a PowerShell
                    // hashtable are wrapped with PSObject
                    if (fieldValue is PSObject) {
                        var psObject = (PSObject)fieldValue;
                        inputTypeField.SetValue(
                            inputInstance,
                            psObject.BaseObject
                        ); 
                    } else {
                        // Auto type conversion for common use case:
                        //
                        // User specifies a list of values in PowerShell with:
                        //   -InitialValues @{"texts" = @("text1", "text2")}
                        // However it maps in C# here to an object[].
                        // => If fieldValue is an object[] and the target property is a List<T>,
                        //    attempt to convert it to the appropriate List<T>.

                        if (fieldValue is object[] objArray &&
                            inputTypeField.PropertyType.IsGenericType &&
                            inputTypeField.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            // Get the generic type argument of the List<>
                            var genericArgumentType = inputTypeField.PropertyType.GetGenericArguments()[0];

                            // Create a new List of the appropriate type
                            var listType = typeof(List<>).MakeGenericType(genericArgumentType);
                            var list = (IList)Activator.CreateInstance(listType);

                            foreach (var item in objArray)
                            {
                                try
                                {
                                    // Attempt to convert each item to the target type
                                    var convertedItem = Convert.ChangeType(item, genericArgumentType);
                                    list.Add(convertedItem);
                                }
                                catch (Exception ex)
                                {
                                    throw new ArgumentException(
                                        $"Unable to convert item '{item}' to type '{genericArgumentType.Name}'. " +
                                        $"Error: {ex.Message}", ex);
                                }
                            }

                            fieldValue = list;
                        }

                        inputTypeField.SetValue(
                            inputInstance,
                            fieldValue
                        );
                    }
                }
                catch (ArgumentException e) {
                    throw new Exception(
                        String.Format(
                            "Provided value of input field {0} is wrong type: {1}",
                            fieldName,
                            e
                        )
                    );
                }
            }

            return inputInstance;
        }

        /// <summary>
        /// Return an instance of an class, with properties listed in
        /// requestedProperties initialized to non-null values.
        /// </summary>
        /// <param name="objectClassName"></param>
        /// <param name="requestedProperties"></param>
        /// <returns>object</returns>
        /// <exception cref="Exception"></exception>
        public static object InitializeTypeWithSelectedProperties(string objectClassName,
            string[] requestedProperties)
        {

            System.Type returnType = GetTypeByName(objectClassName);

            if (returnType != null)
            {
                object returnInstance = Activator.CreateInstance(returnType);
                PropertyInfo[] returnInstanceProperties = returnType.GetProperties();

                foreach (string requestedProperty in requestedProperties)
                {
                    //reset the object tree back to the return instance
                    object currentObject = returnInstance;
                    string[] requestedPropertyTree = requestedProperty.Split('.');

                    //Walk the requestedPropertyTree
                    for (int i = 0; i < requestedPropertyTree.Length; i++)
                    {
                        PropertyInfo currentProperty = currentObject.GetType()
                            .GetProperty(requestedPropertyTree[i],
                            BindingFlags.IgnoreCase |
                            BindingFlags.Instance |
                            BindingFlags.Public);

                        if (currentProperty == null)
                        {
                            //Console.WriteLine($"WARN: Unable to find property: " +
                            //    $"'{requestedPropertyTree[0]}' when evaluating " +
                            //    $"'{ requestedProperty }'");
                            continue;
                        }

                        //If current property is a string
                        if (currentProperty.PropertyType == typeof(string))
                        {
                            currentProperty.SetValue(currentObject, "FETCH");
                            continue;
                        }

                        //if the property is a list, load or init it.
                        if (currentProperty.PropertyType.IsGenericType &&
                            currentProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            System.Type genericArgumentType = currentProperty.PropertyType
                                .GetGenericArguments()[0];

                            if (currentObject.GetType()
                                .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(currentObject) == null)
                            {
                                // Reassign genericArgumentType to currentPropertyType
                                // to make the code easier to read later on.
                                System.Type currentPropertyType = genericArgumentType;

                                // If the LIST is of an INTERFACE type,
                                // instantiate a list of all types that implement
                                // the interface, ensuring correct GQL fields in
                                // query fragments
                                if (genericArgumentType.IsInterface)
                                {
                                    // Get a list of concrete class instances
                                    MethodInfo typeInstancesMethod =
                                        typeof(InterfaceHelper)
                                        .GetMethod("CreateInstancesOfImplementingTypes");
                                    MethodInfo getInstancesMethod =
                                        typeInstancesMethod
                                        .MakeGenericMethod(genericArgumentType);

                                    object[] parameters = new object[] { genericArgumentType };

                                    IList value = (IList)getInstancesMethod.Invoke(null, parameters);

                                    IList implementingInstances =
                                        InterfaceHelper
                                        .CreateInstancesOfImplementingTypes<object>(genericArgumentType);

                                    IList rtnObjs = CopyList(value);
                                    rtnObjs.Clear();

                                    foreach (var item in value)
                                    {
                                        rtnObjs.Add(InitializeTypeWithSelectedProperties(
                                            item.GetType().Name,
                                            requestedProperties));
                                    }

                                    currentProperty.SetValue(currentObject, rtnObjs);
                                    currentObject = rtnObjs[0];
                                }
                                else //It's not an interface, just init a type
                                {
                                    IList value = (IList)Activator.
                                        CreateInstance(currentProperty.PropertyType)
                                        ?? new List<object>();
                                    value.Add(Activator.
                                        CreateInstance(currentPropertyType));

                                    currentProperty.SetValue(currentObject, value);
                                    currentObject = value[0];
                                }
                            }
                            else
                            {
                                IList value = (IList)currentObject?.GetType()?
                                    .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public)?.GetValue(currentObject);
                                currentObject = value[0];
                            }

                            continue;
                        }
                        //If a class, load or instantiate it
                        if (currentProperty.PropertyType.IsClass)
                        {
                            //Console.WriteLine($"Property {currentProperty.Name} is a Class");
                            if (currentObject.GetType()
                                .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(currentObject) == null)
                            {
                                object item = Activator.CreateInstance(currentProperty.PropertyType);
                                currentProperty.SetValue(currentObject, item);
                                currentObject = item;
                            }
                            else
                            {
                                object item = currentObject.GetType()
                                .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public)
                                .GetValue(currentObject);
                                currentObject = item;
                            }

                            continue;
                        }
                        //If interface, get a compatible concrete class
                        if (currentProperty.PropertyType.IsInterface)
                        {
                            //Console.WriteLine($"Property {currentProperty.Name} is an Interface");
                            if (currentObject.GetType()
                                .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(currentObject) == null)
                            {
                                object item = InterfaceHelper.CreateInstanceOfFirstType(currentProperty.PropertyType);
                                currentProperty.SetValue(currentObject, item);
                                currentObject = item;
                            }
                            else
                            {
                                object item = currentObject.GetType()
                                    .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(currentObject);
                                currentObject = item;
                            }
                            continue;
                        }

                        //If enum
                        else if (currentProperty.PropertyType.IsEnum ||
                            IsNullableEnum(currentProperty))
                        {
                            currentProperty.SetValue(currentObject,
                                Enum.GetValues(GetNullableUnderlyingType(currentProperty))
                                .GetValue(0));
                        }

                        else if (currentProperty.PropertyType == typeof(bool) ||
                            currentProperty.PropertyType == typeof(Boolean) ||
                            currentProperty.PropertyType == typeof(Boolean?))
                        {
                            currentProperty.SetValue(currentObject, true);
                        }
                        else if (currentProperty.PropertyType == typeof(int) ||
                            currentProperty.PropertyType == typeof(Int32) ||
                            currentProperty.PropertyType == typeof(Int32?))
                        {
                            currentProperty.SetValue(currentObject, 0);
                        }
                        else if (currentProperty.PropertyType == typeof(Int64) ||
                            currentProperty.PropertyType == typeof(Int64?))
                        {
                            currentProperty.SetValue(currentObject, (Int64)0);
                        }
                        else if (currentProperty.PropertyType == typeof(double) ||
                            currentProperty.PropertyType == typeof(Double))
                        {
                            currentProperty.SetValue(currentObject, 0);
                        }
                        else if (currentProperty.PropertyType == typeof(DateTime?) ||
                            currentProperty.PropertyType == typeof(DateTime))
                        {
                            currentProperty.SetValue(currentObject, new DateTime());
                        }
                        else
                        {
                            throw new Exception($"Property type not handled: '{currentProperty.PropertyType}'");
                        }
                    }
                }
                return returnInstance;
            }
            else
            {
                throw new Exception($"No type found matching: '{ objectClassName }'");
            }
		}

        private static IList CopyList(IList source)
        {
            IList copy = (IList)Activator.CreateInstance(source.GetType());
            foreach (var item in source)
            {
                copy.Add(item);
            }
            return copy;
        }
    }
}

