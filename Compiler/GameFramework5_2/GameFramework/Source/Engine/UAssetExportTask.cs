#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetExportTask.h")]
///<summary>Contains data for a group of assets to export</summary>
public partial class UAssetExportTask : UObject {
// AssetExportTask
	public UObject Object;
	public UExporter Exporter;
	public string Filename;
	public bool bSelected;
	public bool bReplaceIdentical;
	public bool bPrompt;
	public bool bAutomated;
	public bool bUseFileArchive;
	public bool bWriteEmptyFiles;
	public TArray<UObject> IgnoreObjectList;
	public UObject Options;
	public TArray<string> Errors;
}
