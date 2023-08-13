namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetRegistry/IAssetRegistry.h")]
public partial class UAssetRegistry : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Does the given path contain assets, optionally also testing sub-paths?</summary>
	public virtual bool HasAssets(string PackagePath,bool bRecursive/*=false*/) { return default; }
	///<summary>Gets asset data for the assets in the package with the specified package name</summary>
	public virtual bool GetAssetsByPackageName(string PackageName,TArray<FAssetData> OutAssetData,bool bIncludeOnlyOnDiskAssets/*=false*/,bool bSkipARFilteredAssets/*=true*/) { return default; }
	///<summary>Gets asset data for all assets in the supplied folder path</summary>
	public virtual bool GetAssetsByPath(string PackagePath,TArray<FAssetData> OutAssetData,bool bRecursive/*=false*/,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	///<summary>Gets asset data for all assets in any of the supplied folder paths</summary>
	public virtual bool GetAssetsByPaths(TArray<string> PackagePaths,TArray<FAssetData> OutAssetData,bool bRecursive/*=false*/,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	///<summary>Gets asset data for all assets with the supplied class</summary>
	public virtual bool GetAssetsByClass(FTopLevelAssetPath ClassPathName,TArray<FAssetData> OutAssetData,bool bSearchSubClasses/*=false*/) { return default; }
	///<summary>Gets asset data for all assets that match the filter.</summary>
	public virtual bool GetAssets(FARFilter Filter,TArray<FAssetData> OutAssetData,bool bSkipARFilteredAssets/*=true*/) { return default; }
	///<summary>GetAssetByObjectPath</summary>
	public virtual FAssetData GetAssetByObjectPath(string ObjectPath,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	///<summary>Gets the asset data for the specified object path</summary>
	public virtual FAssetData K2_GetAssetByObjectPath(FSoftObjectPath ObjectPath,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	///<summary>Gets asset data for all assets in the registry.</summary>
	public virtual bool GetAllAssets(TArray<FAssetData> OutAssetData,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	///<summary>Gets a list of paths to objects that are referenced by the supplied package. (On disk references ONLY)</summary>
	public virtual bool K2_GetDependencies(string PackageName,FAssetRegistryDependencyOptions DependencyOptions,TArray<string> OutDependencies) { return default; }
	///<summary>Gets a list of packages that reference the supplied package. (On disk references ONLY)</summary>
	public virtual bool K2_GetReferencers(string PackageName,FAssetRegistryDependencyOptions ReferenceOptions,TArray<string> OutReferencers) { return default; }
	///<summary>Returns true if the specified ClassName&#39;s ancestors could be found. If so, OutAncestorClassNames is a list of all its ancestors. This can be slow if temporary caching mode is not on</summary>
	public virtual bool GetAncestorClassNames(FTopLevelAssetPath ClassPathName,TArray<FTopLevelAssetPath> OutAncestorClassNames) { return default; }
	///<summary>Returns the names of all classes derived by the supplied class names, excluding any classes matching the excluded class names. This can be slow if temporary caching mode is not on</summary>
	public virtual void GetDerivedClassNames(TArray<FTopLevelAssetPath> ClassNames,TSet<FTopLevelAssetPath> ExcludedClassNames,TSet<FTopLevelAssetPath> OutDerivedClassNames) {}
	///<summary>Gets a list of all paths that are currently cached</summary>
	public virtual void GetAllCachedPaths(TArray<string> OutPathList) {}
	///<summary>Gets a list of all paths that are currently cached below the passed-in base path</summary>
	public virtual void GetSubPaths(string InBasePath,TArray<string> OutPathList,bool bInRecurse) {}
	///<summary>Trims items out of the asset data list that do not pass the supplied filter</summary>
	public virtual void RunAssetsThroughFilter(TArray<FAssetData> AssetDataList,FARFilter Filter) {}
	///<summary>Trims items out of the asset data list that pass the supplied filter</summary>
	public virtual void UseFilterToExcludeAssets(TArray<FAssetData> AssetDataList,FARFilter Filter) {}
	///<summary>Scan the supplied paths recursively right now and populate the asset registry. If bForceRescan is true, the paths will be scanned again, even if they were previously scanned</summary>
	public virtual void ScanPathsSynchronous(TArray<string> InPaths,bool bForceRescan/*=false*/,bool bIgnoreDenyListScanFilters/*=false*/) {}
	///<summary>Scan the specified individual files right now and populate the asset registry. If bForceRescan is true, the paths will be scanned again, even if they were previously scanned</summary>
	public virtual void ScanFilesSynchronous(TArray<string> InFilePaths,bool bForceRescan/*=false*/) {}
	///<summary>Look for all assets on disk (can be async or synchronous)</summary>
	public virtual void SearchAllAssets(bool bSynchronousSearch) {}
	///<summary>Whether SearchAllAssets has been called, or was auto-called at startup. When async (editor or cooking), if SearchAllAssets has ever been called,</summary>
	public virtual bool IsSearchAllAssets() { return default; }
	///<summary>Whether searching is done async (and was started at startup), or synchronously and on-demand, requiring ScanPathsSynchronous or SearchAllAssets.</summary>
	public virtual bool IsSearchAsync() { return default; }
	///<summary>Wait for scan to be complete. If called during editor startup before OnPostEngineInit, and there are any assets that use classes in</summary>
	public virtual void WaitForCompletion() {}
	///<summary>Wait for the scan of a specific package to be complete</summary>
	public virtual void WaitForPackage(string PackageName) {}
	///<summary>If assets are currently being asynchronously scanned in the specified path, this will cause them to be scanned before other assets.</summary>
	public virtual void PrioritizeSearchPath(string PathToPrioritize) {}
	///<summary>Forces a rescan of specific filenames, call this when you need to refresh from disk</summary>
	public virtual void ScanModifiedAssetFiles(TArray<string> InFilePaths) {}
	///<summary>Returns true if the asset registry is currently loading files and does not yet know about all assets</summary>
	public virtual bool IsLoadingAssets() { return default; }
}
