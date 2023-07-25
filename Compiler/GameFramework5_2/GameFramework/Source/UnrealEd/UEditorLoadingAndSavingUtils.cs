#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FileHelpers.h")]
///<summary>This class is a wrapper for editor loading and saving functionality</summary>
public partial class UEditorLoadingAndSavingUtils : UObject {
// EditorLoadingAndSavingUtils
	public UObject NewBlankMap(bool bSaveExistingMap) { return default; }
	public UObject NewMapFromTemplate(string PathToTemplateLevel,bool bSaveExistingMap) { return default; }
	public UObject LoadMapWithDialog() { return default; }
	public UObject LoadMap(string Filename) { return default; }
	public bool SaveMap(UObject World,string AssetPath) { return default; }
	public bool SavePackages(TArray<UObject> PackagesToSave,bool bOnlyDirty) { return default; }
	public bool SavePackagesWithDialog(TArray<UObject> PackagesToSave,bool bOnlyDirty) { return default; }
	public bool SaveDirtyPackages(bool bSaveMapPackages,bool bSaveContentPackages) { return default; }
	public bool SaveDirtyPackagesWithDialog(bool bSaveMapPackages,bool bSaveContentPackages) { return default; }
	public bool SaveCurrentLevel() { return default; }
	public void GetDirtyMapPackages(TArray<UObject> OutDirtyPackages) {}
	public void GetDirtyContentPackages(TArray<UObject> OutDirtyPackages) {}
	public void ImportScene(string Filename) {}
	public void ExportScene(bool bExportSelectedActorsOnly) {}
	public void UnloadPackages(TArray<UObject> PackagesToUnload,bool bOutAnyPackagesUnloaded,string OutErrorMessage) {}
	public void ReloadPackages(TArray<UObject> PackagesToReload,bool bOutAnyPackagesReloaded,string OutErrorMessage,EReloadPackagesInteractionMode InteractionMode/*=EReloadPackagesInteractionMode.Interactive*/) {}
}
