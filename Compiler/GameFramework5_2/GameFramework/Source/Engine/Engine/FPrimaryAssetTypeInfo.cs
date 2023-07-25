#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/AssetManagerTypes.h")]
///<summary>Structure with publicly exposed information about an asset type. These can be loaded out of a config file.</summary>
public partial struct FPrimaryAssetTypeInfo {
// PrimaryAssetTypeInfo
	public string PrimaryAssetType;
	public TSoftObjectPtr<UClass> AssetBaseClass;
	public UClass AssetBaseClassLoaded;
	public bool bHasBlueprintClasses;
	public bool bIsEditorOnly;
	public TArray<FDirectoryPath> Directories;
	public TArray<FSoftObjectPath> SpecificAssets;
	public FPrimaryAssetRules Rules;
	public TArray<string> AssetScanPaths;
	public bool bIsDynamicAsset;
	public int NumberOfAssets;
}
