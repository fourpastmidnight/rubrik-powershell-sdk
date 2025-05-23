// GlobalSlaStatus.cs
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
    #region GlobalSlaStatus
    public class GlobalSlaStatus: BaseType
    {
        #region members

        //      C# -> PauseStatus? PauseStatus
        // GraphQL -> pauseStatus: PauseStatus! (enum)
        [JsonProperty("pauseStatus")]
        public PauseStatus? PauseStatus { get; set; }

        //      C# -> SlaSyncStatus? SyncStatus
        // GraphQL -> syncStatus: SlaSyncStatus! (enum)
        [JsonProperty("syncStatus")]
        public SlaSyncStatus? SyncStatus { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> PausedSlaInfo? PausedSlaInfo
        // GraphQL -> pausedSlaInfo: PausedSlaInfo (type)
        [JsonProperty("pausedSlaInfo")]
        public PausedSlaInfo? PausedSlaInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GlobalSlaStatus";
    }

    public GlobalSlaStatus Set(
        PauseStatus? PauseStatus = null,
        SlaSyncStatus? SyncStatus = null,
        Cluster? Cluster = null,
        PausedSlaInfo? PausedSlaInfo = null
    ) 
    {
        if ( PauseStatus != null ) {
            this.PauseStatus = PauseStatus;
        }
        if ( SyncStatus != null ) {
            this.SyncStatus = SyncStatus;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( PausedSlaInfo != null ) {
            this.PausedSlaInfo = PausedSlaInfo;
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
        //      C# -> PauseStatus? PauseStatus
        // GraphQL -> pauseStatus: PauseStatus! (enum)
        if (this.PauseStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pauseStatus\n" ;
            } else {
                s += ind + "pauseStatus\n" ;
            }
        }
        //      C# -> SlaSyncStatus? SyncStatus
        // GraphQL -> syncStatus: SlaSyncStatus! (enum)
        if (this.SyncStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "syncStatus\n" ;
            } else {
                s += ind + "syncStatus\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PausedSlaInfo? PausedSlaInfo
        // GraphQL -> pausedSlaInfo: PausedSlaInfo (type)
        if (this.PausedSlaInfo != null) {
            var fspec = this.PausedSlaInfo.AsFieldSpec(conf.Child("pausedSlaInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pausedSlaInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PauseStatus? PauseStatus
        // GraphQL -> pauseStatus: PauseStatus! (enum)
        if (ec.Includes("pauseStatus",true))
        {
            if(this.PauseStatus == null) {

                this.PauseStatus = new PauseStatus();

            } else {


            }
        }
        else if (this.PauseStatus != null && ec.Excludes("pauseStatus",true))
        {
            this.PauseStatus = null;
        }
        //      C# -> SlaSyncStatus? SyncStatus
        // GraphQL -> syncStatus: SlaSyncStatus! (enum)
        if (ec.Includes("syncStatus",true))
        {
            if(this.SyncStatus == null) {

                this.SyncStatus = new SlaSyncStatus();

            } else {


            }
        }
        else if (this.SyncStatus != null && ec.Excludes("syncStatus",true))
        {
            this.SyncStatus = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> PausedSlaInfo? PausedSlaInfo
        // GraphQL -> pausedSlaInfo: PausedSlaInfo (type)
        if (ec.Includes("pausedSlaInfo",false))
        {
            if(this.PausedSlaInfo == null) {

                this.PausedSlaInfo = new PausedSlaInfo();
                this.PausedSlaInfo.ApplyExploratoryFieldSpec(ec.NewChild("pausedSlaInfo"));

            } else {

                this.PausedSlaInfo.ApplyExploratoryFieldSpec(ec.NewChild("pausedSlaInfo"));

            }
        }
        else if (this.PausedSlaInfo != null && ec.Excludes("pausedSlaInfo",false))
        {
            this.PausedSlaInfo = null;
        }
    }


    #endregion

    } // class GlobalSlaStatus
    
    #endregion

    public static class ListGlobalSlaStatusExtensions
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
            this List<GlobalSlaStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GlobalSlaStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GlobalSlaStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalSlaStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GlobalSlaStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types