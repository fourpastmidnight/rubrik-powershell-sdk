// CreateReplicationPairInput.cs
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
    #region CreateReplicationPairInput

    public class CreateReplicationPairInput: IInput
    {
        #region members

        //      C# -> ReplicationGatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: ReplicationGatewayInfo (input)
        [JsonProperty("sourceGateway")]
        public ReplicationGatewayInfo? SourceGateway { get; set; }

        //      C# -> ReplicationGatewayInfo? TargetGateway
        // GraphQL -> targetGateway: ReplicationGatewayInfo (input)
        [JsonProperty("targetGateway")]
        public ReplicationGatewayInfo? TargetGateway { get; set; }

        //      C# -> NetworkInterfaceSelection? NetworkInterface
        // GraphQL -> networkInterface: NetworkInterfaceSelection (input)
        [JsonProperty("networkInterface")]
        public NetworkInterfaceSelection? NetworkInterface { get; set; }

        //      C# -> System.String? SourceClusterUuid
        // GraphQL -> sourceClusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceClusterUuid")]
        public System.String? SourceClusterUuid { get; set; }

        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetClusterUuid")]
        public System.String? TargetClusterUuid { get; set; }

        //      C# -> ReplicationSetupType? SetupType
        // GraphQL -> setupType: ReplicationSetupType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("setupType")]
        public ReplicationSetupType? SetupType { get; set; }

        //      C# -> System.Boolean? UseIpv6
        // GraphQL -> useIpv6: Boolean (scalar)
        [JsonProperty("useIpv6")]
        public System.Boolean? UseIpv6 { get; set; }


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

    } // class CreateReplicationPairInput
    #endregion

} // namespace RubrikSecurityCloud.Types