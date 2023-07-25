#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/AssetManagerSettings.h")]
///<summary>Settings for the Asset Management framework, which can be used to discover, load, and audit game-specific asset types</summary>
public partial class UAssetManagerSettings : UDeveloperSettings {
// AssetManagerSettings
	public TArray<FPrimaryAssetTypeInfo> PrimaryAssetTypesToScan;
	public TArray<FDirectoryPath> DirectoriesToExclude;
	public TArray<FPrimaryAssetRulesOverride> PrimaryAssetRules;
	public TArray<FPrimaryAssetRulesCustomOverride> CustomPrimaryAssetRules;
	public bool bOnlyCookProductionAssets;
	public bool bShouldManagerDetermineTypeAndName;
	public bool bShouldGuessTypeAndNameInEditor;
	public bool bShouldAcquireMissingChunksOnLoad;
	public bool bShouldWarnAboutInvalidAssets;
	public TArray<FAssetManagerRedirect> PrimaryAssetIdRedirects;
	public TArray<FAssetManagerRedirect> PrimaryAssetTypeRedirects;
	public TArray<FAssetManagerRedirect> AssetPathRedirects;
	public TSet<string> MetaDataTagsForAssetRegistry;
}
