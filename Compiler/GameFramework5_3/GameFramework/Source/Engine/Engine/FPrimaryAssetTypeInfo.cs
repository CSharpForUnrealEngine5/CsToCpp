namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure with publicly exposed information about an asset type. These can be loaded out of a config file.</summary>
[CppInclude("Engine/AssetManagerTypes.h")]
public partial struct FPrimaryAssetTypeInfo {
	public FName PrimaryAssetType;
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
