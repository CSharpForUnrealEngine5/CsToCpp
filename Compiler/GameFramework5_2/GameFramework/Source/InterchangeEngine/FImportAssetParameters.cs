namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeManager.h")]
public partial struct FImportAssetParameters {
	public UObject ReimportAsset;
	public int ReimportSourceIndex;
	public bool bIsAutomated;
	public TArray<UInterchangePipelineBase> OverridePipelines;
	public FOnObjectImportDoneDynamic OnAssetDone;
	public FOnImportDoneDynamic OnAssetsImportDone;
	public FOnObjectImportDoneDynamic OnSceneObjectDone;
	public FOnImportDoneDynamic OnSceneImportDone;
}
