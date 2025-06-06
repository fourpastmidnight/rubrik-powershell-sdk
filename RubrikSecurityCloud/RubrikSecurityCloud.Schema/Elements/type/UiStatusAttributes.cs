// UiStatusAttributes.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region UiStatusAttributes
    public class UiStatusAttributes: BaseType
    {
        #region members

        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        [JsonProperty("endTime")]
        public System.String? EndTime { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.Int32? RemainingTimeSec
        // GraphQL -> remainingTimeSec: Int (scalar)
        [JsonProperty("remainingTimeSec")]
        public System.Int32? RemainingTimeSec { get; set; }

        //      C# -> System.Int32? RuDoneNodesCount
        // GraphQL -> ruDoneNodesCount: Int (scalar)
        [JsonProperty("ruDoneNodesCount")]
        public System.Int32? RuDoneNodesCount { get; set; }

        //      C# -> System.Int32? RuTotalNodesCount
        // GraphQL -> ruTotalNodesCount: Int (scalar)
        [JsonProperty("ruTotalNodesCount")]
        public System.Int32? RuTotalNodesCount { get; set; }

        //      C# -> System.String? SourceVersion
        // GraphQL -> sourceVersion: String (scalar)
        [JsonProperty("sourceVersion")]
        public System.String? SourceVersion { get; set; }

        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String (scalar)
        [JsonProperty("startTime")]
        public System.String? StartTime { get; set; }

        //      C# -> System.String? TargetVersion
        // GraphQL -> targetVersion: String (scalar)
        [JsonProperty("targetVersion")]
        public System.String? TargetVersion { get; set; }

        //      C# -> System.String? UpgradeScheduledTime
        // GraphQL -> upgradeScheduledTime: String (scalar)
        [JsonProperty("upgradeScheduledTime")]
        public System.String? UpgradeScheduledTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UiStatusAttributes";
    }

    public UiStatusAttributes Set(
        System.String? EndTime = null,
        System.Single? Progress = null,
        System.Int32? RemainingTimeSec = null,
        System.Int32? RuDoneNodesCount = null,
        System.Int32? RuTotalNodesCount = null,
        System.String? SourceVersion = null,
        System.String? StartTime = null,
        System.String? TargetVersion = null,
        System.String? UpgradeScheduledTime = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( RemainingTimeSec != null ) {
            this.RemainingTimeSec = RemainingTimeSec;
        }
        if ( RuDoneNodesCount != null ) {
            this.RuDoneNodesCount = RuDoneNodesCount;
        }
        if ( RuTotalNodesCount != null ) {
            this.RuTotalNodesCount = RuTotalNodesCount;
        }
        if ( SourceVersion != null ) {
            this.SourceVersion = SourceVersion;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TargetVersion != null ) {
            this.TargetVersion = TargetVersion;
        }
        if ( UpgradeScheduledTime != null ) {
            this.UpgradeScheduledTime = UpgradeScheduledTime;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> System.Int32? RemainingTimeSec
        // GraphQL -> remainingTimeSec: Int (scalar)
        if (this.RemainingTimeSec != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remainingTimeSec\n" ;
            } else {
                s += ind + "remainingTimeSec\n" ;
            }
        }
        //      C# -> System.Int32? RuDoneNodesCount
        // GraphQL -> ruDoneNodesCount: Int (scalar)
        if (this.RuDoneNodesCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ruDoneNodesCount\n" ;
            } else {
                s += ind + "ruDoneNodesCount\n" ;
            }
        }
        //      C# -> System.Int32? RuTotalNodesCount
        // GraphQL -> ruTotalNodesCount: Int (scalar)
        if (this.RuTotalNodesCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ruTotalNodesCount\n" ;
            } else {
                s += ind + "ruTotalNodesCount\n" ;
            }
        }
        //      C# -> System.String? SourceVersion
        // GraphQL -> sourceVersion: String (scalar)
        if (this.SourceVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVersion\n" ;
            } else {
                s += ind + "sourceVersion\n" ;
            }
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? TargetVersion
        // GraphQL -> targetVersion: String (scalar)
        if (this.TargetVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetVersion\n" ;
            } else {
                s += ind + "targetVersion\n" ;
            }
        }
        //      C# -> System.String? UpgradeScheduledTime
        // GraphQL -> upgradeScheduledTime: String (scalar)
        if (this.UpgradeScheduledTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeScheduledTime\n" ;
            } else {
                s += ind + "upgradeScheduledTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = "FETCH";

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = new System.Single();

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
        //      C# -> System.Int32? RemainingTimeSec
        // GraphQL -> remainingTimeSec: Int (scalar)
        if (ec.Includes("remainingTimeSec",true))
        {
            if(this.RemainingTimeSec == null) {

                this.RemainingTimeSec = Int32.MinValue;

            } else {


            }
        }
        else if (this.RemainingTimeSec != null && ec.Excludes("remainingTimeSec",true))
        {
            this.RemainingTimeSec = null;
        }
        //      C# -> System.Int32? RuDoneNodesCount
        // GraphQL -> ruDoneNodesCount: Int (scalar)
        if (ec.Includes("ruDoneNodesCount",true))
        {
            if(this.RuDoneNodesCount == null) {

                this.RuDoneNodesCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.RuDoneNodesCount != null && ec.Excludes("ruDoneNodesCount",true))
        {
            this.RuDoneNodesCount = null;
        }
        //      C# -> System.Int32? RuTotalNodesCount
        // GraphQL -> ruTotalNodesCount: Int (scalar)
        if (ec.Includes("ruTotalNodesCount",true))
        {
            if(this.RuTotalNodesCount == null) {

                this.RuTotalNodesCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.RuTotalNodesCount != null && ec.Excludes("ruTotalNodesCount",true))
        {
            this.RuTotalNodesCount = null;
        }
        //      C# -> System.String? SourceVersion
        // GraphQL -> sourceVersion: String (scalar)
        if (ec.Includes("sourceVersion",true))
        {
            if(this.SourceVersion == null) {

                this.SourceVersion = "FETCH";

            } else {


            }
        }
        else if (this.SourceVersion != null && ec.Excludes("sourceVersion",true))
        {
            this.SourceVersion = null;
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = "FETCH";

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? TargetVersion
        // GraphQL -> targetVersion: String (scalar)
        if (ec.Includes("targetVersion",true))
        {
            if(this.TargetVersion == null) {

                this.TargetVersion = "FETCH";

            } else {


            }
        }
        else if (this.TargetVersion != null && ec.Excludes("targetVersion",true))
        {
            this.TargetVersion = null;
        }
        //      C# -> System.String? UpgradeScheduledTime
        // GraphQL -> upgradeScheduledTime: String (scalar)
        if (ec.Includes("upgradeScheduledTime",true))
        {
            if(this.UpgradeScheduledTime == null) {

                this.UpgradeScheduledTime = "FETCH";

            } else {


            }
        }
        else if (this.UpgradeScheduledTime != null && ec.Excludes("upgradeScheduledTime",true))
        {
            this.UpgradeScheduledTime = null;
        }
    }


    #endregion

    } // class UiStatusAttributes
    
    #endregion

    public static class ListUiStatusAttributesExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<UiStatusAttributes> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UiStatusAttributes> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UiStatusAttributes> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UiStatusAttributes());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UiStatusAttributes> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types