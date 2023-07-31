#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains data for a group of assets to export</summary>
[CppInclude("AssetExportTask.h")]
public partial class UAssetExportTask : UObject {
	///<summary>Asset to export</summary>
	public UObject Object;
	///<summary>Optional exporter, otherwise it will be determined automatically</summary>
	public UExporter Exporter;
	///<summary>File to export as</summary>
	public string Filename;
	///<summary>Export selected only</summary>
	public bool bSelected;
	///<summary>Replace identical files</summary>
	public bool bReplaceIdentical;
	///<summary>Allow dialog prompts</summary>
	public bool bPrompt;
	///<summary>Unattended export</summary>
	public bool bAutomated;
	///<summary>Save to a file archive</summary>
	public bool bUseFileArchive;
	///<summary>Write even if file empty</summary>
	public bool bWriteEmptyFiles;
	///<summary>Array of objects to ignore exporting</summary>
	public TArray<UObject> IgnoreObjectList;
	///<summary>Exporter specific options</summary>
	public UObject Options;
	///<summary>Array of error messages encountered during exporter</summary>
	public TArray<string> Errors;
}
