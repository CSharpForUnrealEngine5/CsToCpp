namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAssetTools.h")]
public partial class UAssetTools : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Creates an asset with the specified name, path, and factory</summary>
	public virtual UObject CreateAsset(string AssetName,string PackagePath,UClass AssetClass,UFactory Factory,string CallingContext/*=NAME_None*/) { return default; }
	///<summary>Opens an asset picker dialog and creates an asset with the specified name and path</summary>
	public virtual UObject CreateAssetWithDialog(string AssetName,string PackagePath,UClass AssetClass,UFactory Factory,string CallingContext/*=NAME_None*/,bool bCallConfigureProperties/*=true*/) { return default; }
	///<summary>Opens an asset picker dialog and creates an asset with the specified name and path. Uses OriginalObject as the duplication source.</summary>
	public virtual UObject DuplicateAssetWithDialog(string AssetName,string PackagePath,UObject OriginalObject) { return default; }
	///<summary>Opens an asset picker dialog and creates an asset with the specified name and path.</summary>
	public virtual UObject DuplicateAssetWithDialogAndTitle(string AssetName,string PackagePath,UObject OriginalObject,FText DialogTitle) { return default; }
	///<summary>Creates an asset with the specified name and path. Uses OriginalObject as the duplication source.</summary>
	public virtual UObject DuplicateAsset(string AssetName,string PackagePath,UObject OriginalObject) { return default; }
	///<summary>Renames assets using the specified names.</summary>
	public virtual bool RenameAssets(TArray<FAssetRenameData> AssetsAndNames) { return default; }
	///<summary>Renames assets using the specified names.</summary>
	public virtual EAssetRenameResult RenameAssetsWithDialog(TArray<FAssetRenameData> AssetsAndNames,bool bAutoCheckout/*=false*/) { return default; }
	///<summary>Returns list of objects that soft reference the given soft object path. This will load assets into memory to verify</summary>
	public virtual void FindSoftReferencesToObject(FSoftObjectPath TargetObject,TArray<UObject> ReferencingObjects) {}
	///<summary>Function that renames all FSoftObjectPath object with the old asset path to the new one.</summary>
	public virtual void RenameReferencingSoftObjectPaths(TArray<UPackage> PackagesToCheck,TMap<FSoftObjectPath,FSoftObjectPath> AssetRedirectorMap) {}
	///<summary>Opens a file open dialog to choose files to import to the destination path.</summary>
	public virtual TArray<UObject> ImportAssetsWithDialog(string DestinationPath) { return default; }
	///<summary>Imports assets using data specified completely up front.  Does not ever ask any questions of the user or show any modal error messages</summary>
	public virtual TArray<UObject> ImportAssetsAutomated(UAutomatedAssetImportData ImportData) { return default; }
	///<summary>Imports assets using tasks specified.</summary>
	public virtual void ImportAssetTasks(TArray<UAssetImportTask> ImportTasks) {}
	///<summary>Exports the specified objects to file.</summary>
	public virtual void ExportAssets(TArray<string> AssetsToExport,string ExportPath) {}
	///<summary>Exports the specified objects to file. First prompting the user to pick an export directory and optionally prompting the user to pick a unique directory per file</summary>
	public virtual void ExportAssetsWithDialog(TArray<string> AssetsToExport,bool bPromptForIndividualFilenames) {}
	///<summary>Creates a unique package and asset name taking the form InBasePackageName+InSuffix</summary>
	public virtual void CreateUniqueAssetName(string InBasePackageName,string InSuffix,string OutPackageName,string OutAssetName) {}
	///<summary>Try to diff the local version of an asset against the latest one from the depot</summary>
	public virtual void DiffAgainstDepot(UObject InObject,string InPackagePath,string InPackageName) {}
	///<summary>Try and diff two assets using class-specific tool. Will do nothing if either asset is NULL, or they are not the same class.</summary>
	public virtual void DiffAssets(UObject OldAsset,UObject NewAsset,FRevisionInfo OldRevision,FRevisionInfo NewRevision) {}
	///<summary>Migrate packages and dependencies to another folder</summary>
	public virtual void MigratePackages(TArray<string> PackageNamesToMigrate,string DestinationPath,FMigrationOptions Options/*=new FMigrationOptions()*/) {}
	///<summary>BeginAdvancedCopyPackages</summary>
	public virtual void BeginAdvancedCopyPackages(TArray<string> InputNamesToCopy,string TargetPath,FAdvancedCopyCompletedEvent OnCopyComplete) {}
	///<summary>Opens editor for assets</summary>
	public virtual void OpenEditorForAssets(TArray<UObject> Assets) {}
}
