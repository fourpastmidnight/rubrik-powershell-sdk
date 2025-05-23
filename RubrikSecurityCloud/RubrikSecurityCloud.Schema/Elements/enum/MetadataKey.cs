// MetadataKey.cs
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
    public enum MetadataKey
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CAN_TABLE_ROW_EXPAND")]
        CAN_TABLE_ROW_EXPAND,

        [EnumMember(Value = "CLUSTER_LINK_ID")]
        CLUSTER_LINK_ID,

        [EnumMember(Value = "CUSTOM_CELL_TYPE")]
        CUSTOM_CELL_TYPE,

        [EnumMember(Value = "HIDE_CHART_LEGEND")]
        HIDE_CHART_LEGEND,

        [EnumMember(Value = "HIDE_CHART_LEGEND_NUMBER")]
        HIDE_CHART_LEGEND_NUMBER,

        [EnumMember(Value = "INVALID_CHART_USER_MESSAGE")]
        INVALID_CHART_USER_MESSAGE,

        [EnumMember(Value = "METADATA_KEY_UNSPECIFIED")]
        METADATA_KEY_UNSPECIFIED,

        [EnumMember(Value = "OBJECT_ICON_ID")]
        OBJECT_ICON_ID,

        [EnumMember(Value = "OBJECT_LINK_ID")]
        OBJECT_LINK_ID,

        [EnumMember(Value = "OBJECT_LINK_TYPE")]
        OBJECT_LINK_TYPE,

        [EnumMember(Value = "ORG_ID")]
        ORG_ID,

        [EnumMember(Value = "SLA_DOMAIN_LINK_ID")]
        SLA_DOMAIN_LINK_ID,

        [EnumMember(Value = "TABLE_CELL_DOT_COLOR")]
        TABLE_CELL_DOT_COLOR,

        [EnumMember(Value = "TABLE_ROW_HOVER_COLOR")]
        TABLE_ROW_HOVER_COLOR,

        [EnumMember(Value = "TABLE_ROW_NAME")]
        TABLE_ROW_NAME


    } // enum MetadataKey

} // namespace RubrikSecurityCloud.Types