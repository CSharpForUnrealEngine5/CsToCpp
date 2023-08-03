#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Expose editor utility functions to Blutilities</summary>
[CppInclude("EditorUtilityLibrary.h")]
public partial class UEditorUtilityLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetSelectionSet</summary>
	public static TArray<AActor> GetSelectionSet() { return default; }
	///<summary>GetSelectionBounds</summary>
	public static void GetSelectionBounds(FVector Origin,FVector BoxExtent,float SphereRadius) {}
	///<summary>Gets the set of currently selected assets</summary>
	public static TArray<UObject> GetSelectedAssets() { return default; }
	///<summary>GetSelectedAssetsOfClass</summary>
	public static TArray<UObject> GetSelectedAssetsOfClass(UClass AssetClass) { return default; }
	///<summary>Gets the set of currently selected classes</summary>
	public static TArray<UClass> GetSelectedBlueprintClasses() { return default; }
	///<summary>Gets the set of currently selected asset data</summary>
	public static TArray<FAssetData> GetSelectedAssetData() { return default; }
	///<summary>Renames an asset (cannot move folders)</summary>
	public static void RenameAsset(UObject Asset,string NewName) {}
	///<summary>Attempts to find the actor specified by PathToActor in the current editor world</summary>
	public  AActor GetActorReference(string PathToActor) { return default; }
	///<summary>Attempts to get the path for the active content browser, returns false if there is no active content browser</summary>
	public static bool GetCurrentContentBrowserPath(string OutPath) { return default; }
	///<summary>Gets the path to the currently selected folder in the content browser</summary>
	public static TArray<string> GetSelectedFolderPaths() { return default; }
	///<summary>Sync the Content Browser to the given folder(s)</summary>
	public static void SyncBrowserToFolders(TArray<string> FolderList) {}
}
