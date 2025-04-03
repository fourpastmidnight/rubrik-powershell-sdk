// SapHanaRecoverableRangeFilterInput.cs
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
    #region SapHanaRecoverableRangeFilterInput

    public class SapHanaRecoverableRangeFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ClusterUuid
        // GraphQL -> clusterUuid: [UUID!] (scalar)
        [JsonProperty("clusterUuid")]
        public List<System.String>? ClusterUuid { get; set; }

        //      C# -> List<System.String>? DatabaseId
        // GraphQL -> databaseId: [String!] (scalar)
        [JsonProperty("databaseId")]
        public List<System.String>? DatabaseId { get; set; }

        //      C# -> DateTime? FromTime
        // GraphQL -> fromTime: DateTime (scalar)
        [JsonProperty("fromTime")]
        public DateTime? FromTime { get; set; }

        //      C# -> DateTime? ToTime
        // GraphQL -> toTime: DateTime (scalar)
        [JsonProperty("toTime")]
        public DateTime? ToTime { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> DateTime? StartBeforeTime
        // GraphQL -> startBeforeTime: DateTime (scalar)
        [JsonProperty("startBeforeTime")]
        public DateTime? StartBeforeTime { get; set; }

        //      C# -> DateTime? EndAfterTime
        // GraphQL -> endAfterTime: DateTime (scalar)
        [JsonProperty("endAfterTime")]
        public DateTime? EndAfterTime { get; set; }


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

    } // class SapHanaRecoverableRangeFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types