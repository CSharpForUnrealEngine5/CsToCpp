#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityLibrary.h")]
///<summary>Expose editor utility functions to Blutilities</summary>
public partial class UEditorUtilityLibrary : UBlueprintFunctionLibrary {
// EditorUtilityLibrary
	public TArray<UObject> GetSelectionSet() { return default; }
	public void GetSelectionBounds(FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public TArray<UObject> GetSelectedAssets() { return default; }
	public TArray<UObject> GetSelectedAssetsOfClass(UClass AssetClass) { return default; }
	public TArray<UClass> GetSelectedBlueprintClasses() { return default; }
	public TArray<FAssetData> GetSelectedAssetData() { return default; }
	public void RenameAsset(UObject Asset,string NewName) {}
	public UObject GetActorReference(string PathToActor) { return default; }
	public bool GetCurrentContentBrowserPath(string OutPath) { return default; }
	public TArray<string> GetSelectedFolderPaths() { return default; }
	public void SyncBrowserToFolders(TArray<string> FolderList) {}
}
