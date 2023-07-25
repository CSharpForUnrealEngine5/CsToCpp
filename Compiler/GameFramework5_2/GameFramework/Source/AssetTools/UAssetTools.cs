#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAssetTools.h")]
public partial class UAssetTools : UInterface {
// AssetTools
	public UObject CreateAsset(string AssetName,string PackagePath,UClass AssetClass,UObject Factory,string CallingContext/*=NAME_None*/) { return default; }
	public UObject CreateAssetWithDialog(string AssetName,string PackagePath,UClass AssetClass,UObject Factory,string CallingContext/*=NAME_None*/,bool bCallConfigureProperties/*=true*/) { return default; }
	public UObject DuplicateAssetWithDialog(string AssetName,string PackagePath,UObject OriginalObject) { return default; }
	public UObject DuplicateAssetWithDialogAndTitle(string AssetName,string PackagePath,UObject OriginalObject,string DialogTitle) { return default; }
	public UObject DuplicateAsset(string AssetName,string PackagePath,UObject OriginalObject) { return default; }
	public bool RenameAssets(TArray<FAssetRenameData> AssetsAndNames) { return default; }
	public EAssetRenameResult RenameAssetsWithDialog(TArray<FAssetRenameData> AssetsAndNames,bool bAutoCheckout/*=false*/) { return default; }
	public void FindSoftReferencesToObject(FSoftObjectPath TargetObject,TArray<UObject> ReferencingObjects) {}
	public void RenameReferencingSoftObjectPaths(TArray<UObject> PackagesToCheck,TMap<FSoftObjectPath,FSoftObjectPath> AssetRedirectorMap) {}
	public TArray<UObject> ImportAssetsWithDialog(string DestinationPath) { return default; }
	public TArray<UObject> ImportAssetsAutomated(UObject ImportData) { return default; }
	public void ImportAssetTasks(TArray<UObject> ImportTasks) {}
	public void ExportAssets(TArray<string> AssetsToExport,string ExportPath) {}
	public void ExportAssetsWithDialog(TArray<string> AssetsToExport,bool bPromptForIndividualFilenames) {}
	public void CreateUniqueAssetName(string InBasePackageName,string InSuffix,string OutPackageName,string OutAssetName) {}
	public void DiffAgainstDepot(UObject InObject,string InPackagePath,string InPackageName) {}
	public void DiffAssets(UObject OldAsset,UObject NewAsset,FRevisionInfo OldRevision,FRevisionInfo NewRevision) {}
	public void MigratePackages(TArray<string> PackageNamesToMigrate,string DestinationPath,FMigrationOptions Options/*=new FMigrationOptions()*/) {}
	public void BeginAdvancedCopyPackages(TArray<string> InputNamesToCopy,string TargetPath,FAdvancedCopyCompletedEvent OnCopyComplete) {}
	public void OpenEditorForAssets(TArray<UObject> Assets) {}
}
