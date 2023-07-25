#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorFramework/AssetImportData.h")]
///<summary>todo: Make this class better suited to multiple import paths - maybe have FAssetImportInfo use a map rather than array?</summary>
public partial class UAssetImportData : UObject {
// AssetImportData
	public void ScriptedAddFilename(string InPath,int Index,string SourceFileLabel) {}
	public string SourceFilePath_DEPRECATED;
	public string SourceFileTimestamp_DEPRECATED;
	public FAssetImportInfo SourceData;
	public string K2_GetFirstFilename() { return default; }
	public TArray<string> K2_ExtractFilenames() { return default; }
}
