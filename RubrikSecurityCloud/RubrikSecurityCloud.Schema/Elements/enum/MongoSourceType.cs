// MongoSourceType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum MongoSourceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "REPLICA_SET")]
        REPLICA_SET,

        [EnumMember(Value = "SHARDED")]
        SHARDED


    } // enum MongoSourceType

} // namespace RubrikSecurityCloud.Types