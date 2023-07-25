#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/AssetManagerTypes.h")]
///<summary>Rules for how to scan the asset registry for assets matching path and type descriptions</summary>
public partial struct FAssetManagerSearchRules {
// AssetManagerSearchRules
	public TArray<string> AssetScanPaths;
	public TArray<string> IncludePatterns;
	public TArray<string> ExcludePatterns;
	public UClass AssetBaseClass;
	public bool bHasBlueprintClasses;
	public bool bForceSynchronousScan;
	public bool bSkipVirtualPathExpansion;
	public bool bSkipManagerIncludeCheck;
}
