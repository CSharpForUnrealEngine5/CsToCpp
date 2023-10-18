namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rules for how to scan the asset registry for assets matching path and type descriptions</summary>
[CppInclude("Engine/AssetManagerTypes.h")]
public partial struct FAssetManagerSearchRules {
	public TArray<string> AssetScanPaths;
	public TArray<string> IncludePatterns;
	public TArray<string> ExcludePatterns;
	public UClass AssetBaseClass;
	public bool bHasBlueprintClasses;
	public bool bForceSynchronousScan;
	public bool bSkipVirtualPathExpansion;
	public bool bSkipManagerIncludeCheck;
}
