#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityLibrary.h")]
///<summary>Expose editor utility functions to Blutilities</summary>
public partial class UEditorUtilityLibrary : UBlueprintFunctionLibrary {
// EditorUtilityLibrary
	public static TArray<AActor> GetSelectionSet() { return default; }
	public static void GetSelectionBounds(FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public static TArray<UObject> GetSelectedAssets() { return default; }
	public static TArray<UObject> GetSelectedAssetsOfClass(UClass AssetClass) { return default; }
	public static TArray<UClass> GetSelectedBlueprintClasses() { return default; }
	public static TArray<FAssetData> GetSelectedAssetData() { return default; }
	public static void RenameAsset(UObject Asset,string NewName) {}
	public  AActor GetActorReference(string PathToActor) { return default; }
	public static bool GetCurrentContentBrowserPath(string OutPath) { return default; }
	public static TArray<string> GetSelectedFolderPaths() { return default; }
	public static void SyncBrowserToFolders(TArray<string> FolderList) {}
}
