// BackupM365MailboxInput.cs
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
    #region BackupM365MailboxInput

    public class BackupM365MailboxInput: IInput
    {
        #region members

        //      C# -> List<System.String>? WorkloadUuids
        // GraphQL -> workloadUuids: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadUuids")]
        public List<System.String>? WorkloadUuids { get; set; }

        //      C# -> System.String? RetentionSlaId
        // GraphQL -> retentionSlaId: UUID (scalar)
        [JsonProperty("retentionSlaId")]
        public System.String? RetentionSlaId { get; set; }


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

    } // class BackupM365MailboxInput
    #endregion

} // namespace RubrikSecurityCloud.Types