// CreateTprPolicyInput.cs
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
    #region CreateTprPolicyInput

    public class CreateTprPolicyInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> TprPolicyScope? PolicyScope
        // GraphQL -> policyScope: TprPolicyScope! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("policyScope")]
        public TprPolicyScope? PolicyScope { get; set; }

        //      C# -> List<TprPolicyRuleInput>? PolicyRules
        // GraphQL -> policyRules: [TprPolicyRuleInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("policyRules")]
        public List<TprPolicyRuleInput>? PolicyRules { get; set; }

        //      C# -> List<System.String>? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("exemptServiceAccounts")]
        public List<System.String>? ExemptServiceAccounts { get; set; }

        //      C# -> System.Int32? QuorumRequirement
        // GraphQL -> quorumRequirement: Int (scalar)
        [JsonProperty("quorumRequirement")]
        public System.Int32? QuorumRequirement { get; set; }


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

    } // class CreateTprPolicyInput
    #endregion

} // namespace RubrikSecurityCloud.Types