#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericAssetsPipeline.h")]
///<summary>This pipeline is the generic pipeline option for all meshes type and should be call before specialized Mesh pipeline (like generic static mesh or skeletal mesh pipelines)</summary>
public partial class UInterchangeGenericAssetsPipeline : UInterchangePipelineBase {
// InterchangeGenericAssetsPipeline
	public EReimportStrategyFlags ReimportStrategy;
	public bool bUseSourceNameForAsset;
	public string AssetName;
	public FVector ImportOffsetTranslation;
	public FRotator ImportOffsetRotation;
	public float ImportOffsetUniformScale;
	public UInterchangeGenericCommonMeshesProperties CommonMeshesProperties;
	public UInterchangeGenericCommonSkeletalMeshesAndAnimationsProperties CommonSkeletalMeshesAndAnimationsProperties;
	public UInterchangeGenericMeshPipeline MeshPipeline;
	public UInterchangeGenericAnimationPipeline AnimationPipeline;
	public UInterchangeGenericMaterialPipeline MaterialPipeline;
}
