// SuspiciousFileInfo.cs
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
    #region SuspiciousFileInfo
    public class SuspiciousFileInfo: BaseType
    {
        #region members

        //      C# -> System.String? FileId
        // GraphQL -> fileId: String! (scalar)
        [JsonProperty("fileId")]
        public System.String? FileId { get; set; }

        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        [JsonProperty("filePath")]
        public System.String? FilePath { get; set; }

        //      C# -> System.Int64? FileSizeBytes
        // GraphQL -> fileSizeBytes: Long! (scalar)
        [JsonProperty("fileSizeBytes")]
        public System.Int64? FileSizeBytes { get; set; }

        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }

        //      C# -> WorkloadInfo? WorkloadInfo
        // GraphQL -> workloadInfo: WorkloadInfo (type)
        [JsonProperty("workloadInfo")]
        public WorkloadInfo? WorkloadInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SuspiciousFileInfo";
    }

    public SuspiciousFileInfo Set(
        System.String? FileId = null,
        System.String? FilePath = null,
        System.Int64? FileSizeBytes = null,
        DateTime? LastModified = null,
        WorkloadInfo? WorkloadInfo = null
    ) 
    {
        if ( FileId != null ) {
            this.FileId = FileId;
        }
        if ( FilePath != null ) {
            this.FilePath = FilePath;
        }
        if ( FileSizeBytes != null ) {
            this.FileSizeBytes = FileSizeBytes;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( WorkloadInfo != null ) {
            this.WorkloadInfo = WorkloadInfo;
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
        //      C# -> System.String? FileId
        // GraphQL -> fileId: String! (scalar)
        if (this.FileId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileId\n" ;
            } else {
                s += ind + "fileId\n" ;
            }
        }
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (this.FilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filePath\n" ;
            } else {
                s += ind + "filePath\n" ;
            }
        }
        //      C# -> System.Int64? FileSizeBytes
        // GraphQL -> fileSizeBytes: Long! (scalar)
        if (this.FileSizeBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSizeBytes\n" ;
            } else {
                s += ind + "fileSizeBytes\n" ;
            }
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        if (this.LastModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModified\n" ;
            } else {
                s += ind + "lastModified\n" ;
            }
        }
        //      C# -> WorkloadInfo? WorkloadInfo
        // GraphQL -> workloadInfo: WorkloadInfo (type)
        if (this.WorkloadInfo != null) {
            var fspec = this.WorkloadInfo.AsFieldSpec(conf.Child("workloadInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? FileId
        // GraphQL -> fileId: String! (scalar)
        if (ec.Includes("fileId",true))
        {
            if(this.FileId == null) {

                this.FileId = "FETCH";

            } else {


            }
        }
        else if (this.FileId != null && ec.Excludes("fileId",true))
        {
            this.FileId = null;
        }
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (ec.Includes("filePath",true))
        {
            if(this.FilePath == null) {

                this.FilePath = "FETCH";

            } else {


            }
        }
        else if (this.FilePath != null && ec.Excludes("filePath",true))
        {
            this.FilePath = null;
        }
        //      C# -> System.Int64? FileSizeBytes
        // GraphQL -> fileSizeBytes: Long! (scalar)
        if (ec.Includes("fileSizeBytes",true))
        {
            if(this.FileSizeBytes == null) {

                this.FileSizeBytes = new System.Int64();

            } else {


            }
        }
        else if (this.FileSizeBytes != null && ec.Excludes("fileSizeBytes",true))
        {
            this.FileSizeBytes = null;
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        if (ec.Includes("lastModified",true))
        {
            if(this.LastModified == null) {

                this.LastModified = new DateTime();

            } else {


            }
        }
        else if (this.LastModified != null && ec.Excludes("lastModified",true))
        {
            this.LastModified = null;
        }
        //      C# -> WorkloadInfo? WorkloadInfo
        // GraphQL -> workloadInfo: WorkloadInfo (type)
        if (ec.Includes("workloadInfo",false))
        {
            if(this.WorkloadInfo == null) {

                this.WorkloadInfo = new WorkloadInfo();
                this.WorkloadInfo.ApplyExploratoryFieldSpec(ec.NewChild("workloadInfo"));

            } else {

                this.WorkloadInfo.ApplyExploratoryFieldSpec(ec.NewChild("workloadInfo"));

            }
        }
        else if (this.WorkloadInfo != null && ec.Excludes("workloadInfo",false))
        {
            this.WorkloadInfo = null;
        }
    }


    #endregion

    } // class SuspiciousFileInfo
    
    #endregion

    public static class ListSuspiciousFileInfoExtensions
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
            this List<SuspiciousFileInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SuspiciousFileInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SuspiciousFileInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SuspiciousFileInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SuspiciousFileInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types