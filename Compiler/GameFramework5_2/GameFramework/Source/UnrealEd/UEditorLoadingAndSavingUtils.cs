#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FileHelpers.h")]
///<summary>This class is a wrapper for editor loading and saving functionality</summary>
public partial class UEditorLoadingAndSavingUtils : UObject {
// EditorLoadingAndSavingUtils
	public static UWorld NewBlankMap(bool bSaveExistingMap) { return default; }
	public static UWorld NewMapFromTemplate(string PathToTemplateLevel,bool bSaveExistingMap) { return default; }
	public static UWorld LoadMapWithDialog() { return default; }
	public static UWorld LoadMap(string Filename) { return default; }
	public static bool SaveMap(UWorld World,string AssetPath) { return default; }
	public static bool SavePackages(TArray<UPackage> PackagesToSave,bool bOnlyDirty) { return default; }
	public static bool SavePackagesWithDialog(TArray<UPackage> PackagesToSave,bool bOnlyDirty) { return default; }
	public static bool SaveDirtyPackages(bool bSaveMapPackages,bool bSaveContentPackages) { return default; }
	public static bool SaveDirtyPackagesWithDialog(bool bSaveMapPackages,bool bSaveContentPackages) { return default; }
	public static bool SaveCurrentLevel() { return default; }
	public static void GetDirtyMapPackages(TArray<UPackage> OutDirtyPackages) {}
	public static void GetDirtyContentPackages(TArray<UPackage> OutDirtyPackages) {}
	public static void ImportScene(string Filename) {}
	public static void ExportScene(bool bExportSelectedActorsOnly) {}
	public static void UnloadPackages(TArray<UPackage> PackagesToUnload,bool bOutAnyPackagesUnloaded,string OutErrorMessage) {}
	public static void ReloadPackages(TArray<UPackage> PackagesToReload,bool bOutAnyPackagesReloaded,string OutErrorMessage,EReloadPackagesInteractionMode InteractionMode/*=EReloadPackagesInteractionMode.Interactive*/) {}
}
