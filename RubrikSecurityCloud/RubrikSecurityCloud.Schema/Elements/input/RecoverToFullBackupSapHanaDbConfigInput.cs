// RecoverToFullBackupSapHanaDbConfigInput.cs
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
    #region RecoverToFullBackupSapHanaDbConfigInput

    public class RecoverToFullBackupSapHanaDbConfigInput: IInput
    {
        #region members

        //      C# -> System.String? RemoteLocationId
        // GraphQL -> remoteLocationId: String (scalar)
        [JsonProperty("remoteLocationId")]
        public System.String? RemoteLocationId { get; set; }

        //      C# -> System.String? DbId
        // GraphQL -> dbId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("dbId")]
        public System.String? DbId { get; set; }

        //      C# -> System.String? FullSnapshotId
        // GraphQL -> fullSnapshotId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fullSnapshotId")]
        public System.String? FullSnapshotId { get; set; }

        //      C# -> SapHanaRestoreSourceConfigInput? SourceDbConfig
        // GraphQL -> sourceDbConfig: SapHanaRestoreSourceConfigInput (input)
        [JsonProperty("sourceDbConfig")]
        public SapHanaRestoreSourceConfigInput? SourceDbConfig { get; set; }


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

    } // class RecoverToFullBackupSapHanaDbConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types