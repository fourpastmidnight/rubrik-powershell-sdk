// CloudDirectSnapshotSateType.cs
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
    public enum CloudDirectSnapshotSateType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CANCELLED")]
        CANCELLED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "FINISHED")]
        FINISHED,

        [EnumMember(Value = "INVALID")]
        INVALID


    } // enum CloudDirectSnapshotSateType

} // namespace RubrikSecurityCloud.Types