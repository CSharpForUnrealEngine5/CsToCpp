namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Asset Management framework, which can be used to discover, load, and audit game-specific asset types</summary>
[CppInclude("Engine/AssetManagerSettings.h")]
public partial class UAssetManagerSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>List of asset types to scan at startup</summary>
	public TArray<FPrimaryAssetTypeInfo> PrimaryAssetTypesToScan;
	///<summary>List of directories to exclude from scanning for Primary Assets, useful to exclude test assets</summary>
	public TArray<FDirectoryPath> DirectoriesToExclude;
	///<summary>List of specific asset rule overrides</summary>
	public TArray<FPrimaryAssetRulesOverride> PrimaryAssetRules;
	///<summary>List of game-specific asset rule overrides for types, this will not do anything by default</summary>
	public TArray<FPrimaryAssetRulesCustomOverride> CustomPrimaryAssetRules;
	///<summary>If true, DevelopmentCook assets will error when they are cooked, you should enable this on production branches</summary>
	public bool bOnlyCookProductionAssets;
	///<summary>If true, the asset manager will determine the type and name for Primary Assets that do not implement GetPrimaryAssetId, by calling DeterminePrimaryAssetIdForObject and using the ini settings.</summary>
	public bool bShouldManagerDetermineTypeAndName;
	///<summary>If true, PrimaryAsset Type/Name will be implied for assets in the editor even if bShouldManagerDetermineTypeAndName is false.</summary>
	public bool bShouldGuessTypeAndNameInEditor;
	///<summary>If true, this will query the platform chunk install interface to request missing chunks for any requested primary asset loads</summary>
	public bool bShouldAcquireMissingChunksOnLoad;
	///<summary>If true, the asset manager will warn when it is told to load or do something with assets it does not know about</summary>
	public bool bShouldWarnAboutInvalidAssets;
	///<summary>Redirect from Type:Name to Type:NameNew</summary>
	public TArray<FAssetManagerRedirect> PrimaryAssetIdRedirects;
	///<summary>Redirect from Type to TypeNew</summary>
	public TArray<FAssetManagerRedirect> PrimaryAssetTypeRedirects;
	///<summary>Redirect from /game/assetpath to /game/assetpathnew</summary>
	public TArray<FAssetManagerRedirect> AssetPathRedirects;
	///<summary>The metadata tags to be transferred to the Asset Registry.</summary>
	public TSet<string> MetaDataTagsForAssetRegistry;
}
