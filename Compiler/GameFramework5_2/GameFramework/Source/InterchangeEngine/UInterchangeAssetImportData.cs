#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAssetImportData.h")]
public partial class UInterchangeAssetImportData : UAssetImportData {
// InterchangeAssetImportData
	public string ScriptGetFirstFilename() { return default; }
	public TArray<string> ScriptExtractFilenames() { return default; }
	public TArray<string> ScriptExtractDisplayLabels() { return default; }
	public UInterchangeBaseNodeContainer NodeContainer;
	public string NodeUniqueID;
	public TArray<UObject> Pipelines;
}
