// VirtualMachineScriptDetail.cs
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
    #region VirtualMachineScriptDetail
    public class VirtualMachineScriptDetail: BaseType
    {
        #region members

        //      C# -> VirtualMachineScriptDetailFailureHandling? FailureHandling
        // GraphQL -> failureHandling: VirtualMachineScriptDetailFailureHandling! (enum)
        [JsonProperty("failureHandling")]
        public VirtualMachineScriptDetailFailureHandling? FailureHandling { get; set; }

        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        [JsonProperty("scriptPath")]
        public System.String? ScriptPath { get; set; }

        //      C# -> System.Int64? TimeoutMs
        // GraphQL -> timeoutMs: Long! (scalar)
        [JsonProperty("timeoutMs")]
        public System.Int64? TimeoutMs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VirtualMachineScriptDetail";
    }

    public VirtualMachineScriptDetail Set(
        VirtualMachineScriptDetailFailureHandling? FailureHandling = null,
        System.String? ScriptPath = null,
        System.Int64? TimeoutMs = null
    ) 
    {
        if ( FailureHandling != null ) {
            this.FailureHandling = FailureHandling;
        }
        if ( ScriptPath != null ) {
            this.ScriptPath = ScriptPath;
        }
        if ( TimeoutMs != null ) {
            this.TimeoutMs = TimeoutMs;
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
        //      C# -> VirtualMachineScriptDetailFailureHandling? FailureHandling
        // GraphQL -> failureHandling: VirtualMachineScriptDetailFailureHandling! (enum)
        if (this.FailureHandling != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failureHandling\n" ;
            } else {
                s += ind + "failureHandling\n" ;
            }
        }
        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        if (this.ScriptPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scriptPath\n" ;
            } else {
                s += ind + "scriptPath\n" ;
            }
        }
        //      C# -> System.Int64? TimeoutMs
        // GraphQL -> timeoutMs: Long! (scalar)
        if (this.TimeoutMs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timeoutMs\n" ;
            } else {
                s += ind + "timeoutMs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> VirtualMachineScriptDetailFailureHandling? FailureHandling
        // GraphQL -> failureHandling: VirtualMachineScriptDetailFailureHandling! (enum)
        if (ec.Includes("failureHandling",true))
        {
            if(this.FailureHandling == null) {

                this.FailureHandling = new VirtualMachineScriptDetailFailureHandling();

            } else {


            }
        }
        else if (this.FailureHandling != null && ec.Excludes("failureHandling",true))
        {
            this.FailureHandling = null;
        }
        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        if (ec.Includes("scriptPath",true))
        {
            if(this.ScriptPath == null) {

                this.ScriptPath = "FETCH";

            } else {


            }
        }
        else if (this.ScriptPath != null && ec.Excludes("scriptPath",true))
        {
            this.ScriptPath = null;
        }
        //      C# -> System.Int64? TimeoutMs
        // GraphQL -> timeoutMs: Long! (scalar)
        if (ec.Includes("timeoutMs",true))
        {
            if(this.TimeoutMs == null) {

                this.TimeoutMs = new System.Int64();

            } else {


            }
        }
        else if (this.TimeoutMs != null && ec.Excludes("timeoutMs",true))
        {
            this.TimeoutMs = null;
        }
    }


    #endregion

    } // class VirtualMachineScriptDetail
    
    #endregion

    public static class ListVirtualMachineScriptDetailExtensions
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
            this List<VirtualMachineScriptDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VirtualMachineScriptDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VirtualMachineScriptDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VirtualMachineScriptDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VirtualMachineScriptDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types