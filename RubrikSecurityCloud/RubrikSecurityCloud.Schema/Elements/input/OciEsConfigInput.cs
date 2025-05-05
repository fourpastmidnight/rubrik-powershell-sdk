// OciEsConfigInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region OciEsConfigInput

    public class OciEsConfigInput: IInput
    {
        #region members

        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String (scalar)
        [JsonProperty("bucketName")]
        public System.String? BucketName { get; set; }

        //      C# -> System.String? OciNamespace
        // GraphQL -> ociNamespace: String (scalar)
        [JsonProperty("ociNamespace")]
        public System.String? OciNamespace { get; set; }

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? SecretKey
        // GraphQL -> secretKey: String (scalar)
        [JsonProperty("secretKey")]
        public System.String? SecretKey { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class OciEsConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types