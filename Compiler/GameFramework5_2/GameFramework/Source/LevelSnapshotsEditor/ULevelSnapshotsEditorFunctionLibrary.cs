#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotsEditorFunctionLibrary.h")]
public partial class ULevelSnapshotsEditorFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>@brief Creates a new Level Snapshot asset in the content browser and then captures the target world</summary>
	public static ULevelSnapshot TakeLevelSnapshotAndSaveToDisk(UObject WorldContextObject,string FileName,string FolderPath,string Description,bool bShouldCreateUniqueFileName/*=true*/) { return default; }
	///<summary>Uses TakeLevelSnapshotAndSaveToDisk() and assumes Editor World</summary>
	public static void TakeAndSaveLevelSnapshotEditorWorld(string FileName,string FolderPath,string Description) {}
	///<summary>If the snapshot is saved in the registry, takes a screenshot of the editor scene and sets it as thumnail for the snapshot.</summary>
	public static void GenerateThumbnailForSnapshotAsset(ULevelSnapshot SnapshotPackage) {}
}
