#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotsEditorFunctionLibrary.h")]
public partial class ULevelSnapshotsEditorFunctionLibrary : UBlueprintFunctionLibrary {
// LevelSnapshotsEditorFunctionLibrary
	public UObject TakeLevelSnapshotAndSaveToDisk(UObject WorldContextObject,string FileName,string FolderPath,string Description,bool bShouldCreateUniqueFileName/*=true*/) { return default; }
	public void TakeAndSaveLevelSnapshotEditorWorld(string FileName,string FolderPath,string Description) {}
	public void GenerateThumbnailForSnapshotAsset(UObject SnapshotPackage) {}
}
