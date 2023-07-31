#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>todo: Make this class better suited to multiple import paths - maybe have FAssetImportInfo use a map rather than array?</summary>
[CppInclude("EditorFramework/AssetImportData.h")]
public partial class UAssetImportData : UObject {
	///<summary>Add or update a filename at the specified index. If the index is greater then the number of source file,</summary>
	public  void ScriptedAddFilename(string InPath,int Index,string SourceFileLabel) {}
	///<summary>Path to the resource used to construct this static mesh. Relative to the object&#39;s package, BaseDir() or absolute</summary>
	public string SourceFilePath_DEPRECATED;
	///<summary>Date/Time-stamp of the file from the last import</summary>
	public string SourceFileTimestamp_DEPRECATED;
	///<summary>Source file data describing the files that were used to import this asset.</summary>
	public FAssetImportInfo SourceData;
	///<summary>Helper function to return the first filename stored in this data. The resulting filename will be absolute (ie, not relative to the asset).</summary>
	public  string K2_GetFirstFilename() { return default; }
	///<summary>K2_ExtractFilenames</summary>
	public  TArray<string> K2_ExtractFilenames() { return default; }
}
