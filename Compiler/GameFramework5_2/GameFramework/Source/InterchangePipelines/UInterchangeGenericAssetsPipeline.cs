#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This pipeline is the generic pipeline option for all meshes type and should be call before specialized Mesh pipeline (like generic static mesh or skeletal mesh pipelines)</summary>
[CppInclude("InterchangeGenericAssetsPipeline.h")]
public partial class UInterchangeGenericAssetsPipeline : UInterchangePipelineBase {
	///<summary>Allow user to choose the re-import strategy.</summary>
	public EReimportStrategyFlags ReimportStrategy;
	///<summary>If enable and AssetName is empty and there is only one asset and one source data, we will name the asset like the source data name.</summary>
	public bool bUseSourceNameForAsset;
	///<summary>If not empty, and there is only one asset and one source data, we will name the asset with this string.</summary>
	public string AssetName;
	///<summary>Translation offset applied to meshes and animations.</summary>
	public FVector ImportOffsetTranslation;
	///<summary>Rotation offset applied to meshes and animations.</summary>
	public FRotator ImportOffsetRotation;
	///<summary>Uniform scale offset applied to meshes and animations.</summary>
	public float ImportOffsetUniformScale;
	///<summary>COMMON_MESHES_CATEGORY Properties</summary>
	public UInterchangeGenericCommonMeshesProperties CommonMeshesProperties;
	///<summary>COMMON_SKELETAL_ANIMATIONS_CATEGORY</summary>
	public UInterchangeGenericCommonSkeletalMeshesAndAnimationsProperties CommonSkeletalMeshesAndAnimationsProperties;
	///<summary>MESHES_CATEGORY Properties</summary>
	public UInterchangeGenericMeshPipeline MeshPipeline;
	///<summary>ANIMATIONS_CATEGORY Properties</summary>
	public UInterchangeGenericAnimationPipeline AnimationPipeline;
	///<summary>MATERIALS_CATEGORY Properties</summary>
	public UInterchangeGenericMaterialPipeline MaterialPipeline;
}
