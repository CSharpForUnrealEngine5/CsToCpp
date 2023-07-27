#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetImportTask.h")]
///<summary>Contains data for a group of assets to import</summary>
public partial class UAssetImportTask : UObject {
// AssetImportTask
	public string Filename;
	public string DestinationPath;
	public string DestinationName;
	public bool bReplaceExisting;
	public bool bReplaceExistingSettings;
	public bool bAutomated;
	public bool bSave;
	public bool bAsync;
	public UFactory Factory;
	public UObject Options;
	public  TArray<UObject> GetObjects() { return default; }
	public  bool IsAsyncImportComplete() { return default; }
	public TArray<string> ImportedObjectPaths;
	public TArray<UObject> Result;
}
