// UserFilterInput.cs
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
    #region UserFilterInput

    public class UserFilterInput: IInput
    {
        #region members

        //      C# -> System.String? EmailFilter
        // GraphQL -> emailFilter: String (scalar)
        [JsonProperty("emailFilter")]
        public System.String? EmailFilter { get; set; }

        //      C# -> List<UserDomainEnum>? DomainFilter
        // GraphQL -> domainFilter: [UserDomainEnum!] (enum)
        [JsonProperty("domainFilter")]
        public List<UserDomainEnum>? DomainFilter { get; set; }

        //      C# -> List<System.String>? OrgIdsFilter
        // GraphQL -> orgIdsFilter: [String!] (scalar)
        [JsonProperty("orgIdsFilter")]
        public List<System.String>? OrgIdsFilter { get; set; }

        //      C# -> List<System.String>? RoleIdsFilter
        // GraphQL -> roleIdsFilter: [String!] (scalar)
        [JsonProperty("roleIdsFilter")]
        public List<System.String>? RoleIdsFilter { get; set; }

        //      C# -> LockoutStateFilter? LockoutStateFilter
        // GraphQL -> lockoutStateFilter: LockoutStateFilter (enum)
        [JsonProperty("lockoutStateFilter")]
        public LockoutStateFilter? LockoutStateFilter { get; set; }

        //      C# -> HiddenStateFilter? HiddenStateFilter
        // GraphQL -> hiddenStateFilter: HiddenStateFilter (enum)
        [JsonProperty("hiddenStateFilter")]
        public HiddenStateFilter? HiddenStateFilter { get; set; }

        //      C# -> List<System.String>? AuthDomainIdsFilter
        // GraphQL -> authDomainIdsFilter: [String!] (scalar)
        [JsonProperty("authDomainIdsFilter")]
        public List<System.String>? AuthDomainIdsFilter { get; set; }

        //      C# -> List<LockMethod>? LockoutReasonsFilter
        // GraphQL -> lockoutReasonsFilter: [LockMethod!] (enum)
        [JsonProperty("lockoutReasonsFilter")]
        public List<LockMethod>? LockoutReasonsFilter { get; set; }


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

    } // class UserFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types