namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeManager.h")]
public partial struct FImportAssetParameters {
	public UObject ReimportAsset;
	public int ReimportSourceIndex;
	public bool bIsAutomated;
	public bool bFollowRedirectors;
	public TArray<FSoftObjectPath> OverridePipelines;
	public FOnObjectImportDoneDynamic OnAssetDone;
	public FOnImportDoneDynamic OnAssetsImportDone;
	public FOnObjectImportDoneDynamic OnSceneObjectDone;
	public FOnImportDoneDynamic OnSceneImportDone;
}
