#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAssetTools.h")]
public partial class UAssetTools : UInterface {
	///<summary>Creates an asset with the specified name, path, and factory</summary>
	public  UObject CreateAsset(string AssetName,string PackagePath,UClass AssetClass,UFactory Factory,string CallingContext/*=NAME_None*/) { return default; }
	///<summary>Opens an asset picker dialog and creates an asset with the specified name and path</summary>
	public  UObject CreateAssetWithDialog(string AssetName,string PackagePath,UClass AssetClass,UFactory Factory,string CallingContext/*=NAME_None*/,bool bCallConfigureProperties/*=true*/) { return default; }
	///<summary>Opens an asset picker dialog and creates an asset with the specified name and path. Uses OriginalObject as the duplication source.</summary>
	public  UObject DuplicateAssetWithDialog(string AssetName,string PackagePath,UObject OriginalObject) { return default; }
	///<summary>Opens an asset picker dialog and creates an asset with the specified name and path.</summary>
	public  UObject DuplicateAssetWithDialogAndTitle(string AssetName,string PackagePath,UObject OriginalObject,string DialogTitle) { return default; }
	///<summary>Creates an asset with the specified name and path. Uses OriginalObject as the duplication source.</summary>
	public  UObject DuplicateAsset(string AssetName,string PackagePath,UObject OriginalObject) { return default; }
	///<summary>Renames assets using the specified names.</summary>
	public  bool RenameAssets(TArray<FAssetRenameData> AssetsAndNames) { return default; }
	///<summary>Renames assets using the specified names.</summary>
	public  EAssetRenameResult RenameAssetsWithDialog(TArray<FAssetRenameData> AssetsAndNames,bool bAutoCheckout/*=false*/) { return default; }
	///<summary>Returns list of objects that soft reference the given soft object path. This will load assets into memory to verify</summary>
	public  void FindSoftReferencesToObject(FSoftObjectPath TargetObject,TArray<UObject> ReferencingObjects) {}
	///<summary>Function that renames all FSoftObjectPath object with the old asset path to the new one.</summary>
	public  void RenameReferencingSoftObjectPaths(TArray<UPackage> PackagesToCheck,TMap<FSoftObjectPath,FSoftObjectPath> AssetRedirectorMap) {}
	///<summary>Opens a file open dialog to choose files to import to the destination path.</summary>
	public  TArray<UObject> ImportAssetsWithDialog(string DestinationPath) { return default; }
	///<summary>Imports assets using data specified completely up front.  Does not ever ask any questions of the user or show any modal error messages</summary>
	public  TArray<UObject> ImportAssetsAutomated(UAutomatedAssetImportData ImportData) { return default; }
	///<summary>Imports assets using tasks specified.</summary>
	public  void ImportAssetTasks(TArray<UAssetImportTask> ImportTasks) {}
	///<summary>Exports the specified objects to file.</summary>
	public  void ExportAssets(TArray<string> AssetsToExport,string ExportPath) {}
	///<summary>Exports the specified objects to file. First prompting the user to pick an export directory and optionally prompting the user to pick a unique directory per file</summary>
	public  void ExportAssetsWithDialog(TArray<string> AssetsToExport,bool bPromptForIndividualFilenames) {}
	///<summary>Creates a unique package and asset name taking the form InBasePackageName+InSuffix</summary>
	public  void CreateUniqueAssetName(string InBasePackageName,string InSuffix,string OutPackageName,string OutAssetName) {}
	///<summary>Try to diff the local version of an asset against the latest one from the depot</summary>
	public  void DiffAgainstDepot(UObject InObject,string InPackagePath,string InPackageName) {}
	///<summary>Try and diff two assets using class-specific tool. Will do nothing if either asset is NULL, or they are not the same class.</summary>
	public  void DiffAssets(UObject OldAsset,UObject NewAsset,FRevisionInfo OldRevision,FRevisionInfo NewRevision) {}
	///<summary>Migrate packages and dependencies to another folder</summary>
	public  void MigratePackages(TArray<string> PackageNamesToMigrate,string DestinationPath,FMigrationOptions Options/*=new FMigrationOptions()*/) {}
	///<summary>BeginAdvancedCopyPackages</summary>
	public  void BeginAdvancedCopyPackages(TArray<string> InputNamesToCopy,string TargetPath,FAdvancedCopyCompletedEvent OnCopyComplete) {}
	///<summary>Opens editor for assets</summary>
	public  void OpenEditorForAssets(TArray<UObject> Assets) {}
}
