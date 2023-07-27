#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetRegistry/IAssetRegistry.h")]
public partial class UAssetRegistry : UInterface {
// AssetRegistry
	public  bool HasAssets(string PackagePath,bool bRecursive/*=false*/) { return default; }
	public  bool GetAssetsByPackageName(string PackageName,TArray<FAssetData> OutAssetData,bool bIncludeOnlyOnDiskAssets/*=false*/,bool bSkipARFilteredAssets/*=true*/) { return default; }
	public  bool GetAssetsByPath(string PackagePath,TArray<FAssetData> OutAssetData,bool bRecursive/*=false*/,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	public  bool GetAssetsByPaths(TArray<string> PackagePaths,TArray<FAssetData> OutAssetData,bool bRecursive/*=false*/,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	public  bool GetAssetsByClass(FTopLevelAssetPath ClassPathName,TArray<FAssetData> OutAssetData,bool bSearchSubClasses/*=false*/) { return default; }
	public  bool GetAssets(FARFilter Filter,TArray<FAssetData> OutAssetData,bool bSkipARFilteredAssets/*=true*/) { return default; }
	public  FAssetData GetAssetByObjectPath(string ObjectPath,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	public  FAssetData K2_GetAssetByObjectPath(FSoftObjectPath ObjectPath,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	public  bool GetAllAssets(TArray<FAssetData> OutAssetData,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	public  bool K2_GetDependencies(string PackageName,FAssetRegistryDependencyOptions DependencyOptions,TArray<string> OutDependencies) { return default; }
	public  bool K2_GetReferencers(string PackageName,FAssetRegistryDependencyOptions ReferenceOptions,TArray<string> OutReferencers) { return default; }
	public  bool GetAncestorClassNames(FTopLevelAssetPath ClassPathName,TArray<FTopLevelAssetPath> OutAncestorClassNames) { return default; }
	public  void GetDerivedClassNames(TArray<FTopLevelAssetPath> ClassNames,TSet<FTopLevelAssetPath> ExcludedClassNames,TSet<FTopLevelAssetPath> OutDerivedClassNames) {}
	public  void GetAllCachedPaths(TArray<string> OutPathList) {}
	public  void GetSubPaths(string InBasePath,TArray<string> OutPathList,bool bInRecurse) {}
	public  void RunAssetsThroughFilter(TArray<FAssetData> AssetDataList,FARFilter Filter) {}
	public  void UseFilterToExcludeAssets(TArray<FAssetData> AssetDataList,FARFilter Filter) {}
	public  void ScanPathsSynchronous(TArray<string> InPaths,bool bForceRescan/*=false*/,bool bIgnoreDenyListScanFilters/*=false*/) {}
	public  void ScanFilesSynchronous(TArray<string> InFilePaths,bool bForceRescan/*=false*/) {}
	public  void SearchAllAssets(bool bSynchronousSearch) {}
	public  bool IsSearchAllAssets() { return default; }
	public  bool IsSearchAsync() { return default; }
	public  void WaitForCompletion() {}
	public  void WaitForPackage(string PackageName) {}
	public  void PrioritizeSearchPath(string PathToPrioritize) {}
	public  void ScanModifiedAssetFiles(TArray<string> InFilePaths) {}
	public  bool IsLoadingAssets() { return default; }
}
