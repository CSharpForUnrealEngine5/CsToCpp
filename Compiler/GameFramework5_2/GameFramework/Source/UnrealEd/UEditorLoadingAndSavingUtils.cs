#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is a wrapper for editor loading and saving functionality</summary>
[CppInclude("FileHelpers.h")]
public partial class UEditorLoadingAndSavingUtils : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NewBlankMap</summary>
	public static UWorld NewBlankMap(bool bSaveExistingMap) { return default; }
	///<summary>NewMapFromTemplate</summary>
	public static UWorld NewMapFromTemplate(string PathToTemplateLevel,bool bSaveExistingMap) { return default; }
	///<summary>Prompts the user to save the current map if necessary, the presents a load dialog and</summary>
	public static UWorld LoadMapWithDialog() { return default; }
	///<summary>Loads the specified map.  Does not prompt the user to save the current map.</summary>
	public static UWorld LoadMap(string Filename) { return default; }
	///<summary>Saves the specified map, returning true on success.</summary>
	public static bool SaveMap(UWorld World,string AssetPath) { return default; }
	///<summary>Save all packages.</summary>
	public static bool SavePackages(TArray<UPackage> PackagesToSave,bool bOnlyDirty) { return default; }
	///<summary>Save all packages. Optionally prompting the user to select which packages to save.</summary>
	public static bool SavePackagesWithDialog(TArray<UPackage> PackagesToSave,bool bOnlyDirty) { return default; }
	///<summary>Looks at all currently loaded packages and saves them if their &quot;bDirty&quot; flag is set.</summary>
	public static bool SaveDirtyPackages(bool bSaveMapPackages,bool bSaveContentPackages) { return default; }
	///<summary>Looks at all currently loaded packages and saves them if their &quot;bDirty&quot; flag is set.</summary>
	public static bool SaveDirtyPackagesWithDialog(bool bSaveMapPackages,bool bSaveContentPackages) { return default; }
	///<summary>Saves the active level, prompting the use for checkout if necessary.</summary>
	public static bool SaveCurrentLevel() { return default; }
	///<summary>Appends array with all currently dirty map packages.</summary>
	public static void GetDirtyMapPackages(TArray<UPackage> OutDirtyPackages) {}
	///<summary>Appends array with all currently dirty content packages.</summary>
	public static void GetDirtyContentPackages(TArray<UPackage> OutDirtyPackages) {}
	///<summary>Imports a file such as (FBX or obj) and spawns actors f into the current level</summary>
	public static void ImportScene(string Filename) {}
	///<summary>Exports the current scene</summary>
	public static void ExportScene(bool bExportSelectedActorsOnly) {}
	///<summary>Unloads a list of packages</summary>
	public static void UnloadPackages(TArray<UPackage> PackagesToUnload,bool bOutAnyPackagesUnloaded,string OutErrorMessage) {}
	///<summary>Helper function that attempts to reload the specified top-level packages.</summary>
	public static void ReloadPackages(TArray<UPackage> PackagesToReload,bool bOutAnyPackagesReloaded,string OutErrorMessage,EReloadPackagesInteractionMode InteractionMode/*=EReloadPackagesInteractionMode.Interactive*/) {}
}
