// SetPrivateContainerRegistryInput.cs
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
    #region SetPrivateContainerRegistryInput

    public class SetPrivateContainerRegistryInput: IInput
    {
        #region members

        //      C# -> System.String? ExocomputeAccountId
        // GraphQL -> exocomputeAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("exocomputeAccountId")]
        public System.String? ExocomputeAccountId { get; set; }

        //      C# -> System.String? RegistryUrl
        // GraphQL -> registryUrl: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("registryUrl")]
        public System.String? RegistryUrl { get; set; }

        //      C# -> CloudType? CloudType
        // GraphQL -> cloudType: CloudType (enum)
        [JsonProperty("cloudType")]
        public CloudType? CloudType { get; set; }

        //      C# -> PcrAwsImagePullDetailsInput? PcrAwsImagePullDetails
        // GraphQL -> pcrAwsImagePullDetails: PcrAwsImagePullDetailsInput (input)
        [JsonProperty("pcrAwsImagePullDetails")]
        public PcrAwsImagePullDetailsInput? PcrAwsImagePullDetails { get; set; }

        //      C# -> PcrAzureImagePullDetailsInput? PcrAzureImagePullDetails
        // GraphQL -> pcrAzureImagePullDetails: PcrAzureImagePullDetailsInput (input)
        [JsonProperty("pcrAzureImagePullDetails")]
        public PcrAzureImagePullDetailsInput? PcrAzureImagePullDetails { get; set; }


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

    } // class SetPrivateContainerRegistryInput
    #endregion

} // namespace RubrikSecurityCloud.Types