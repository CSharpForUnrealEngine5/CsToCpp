#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeDatasmithPipeline.h")]
public partial class UInterchangeDatasmithPipeline : UInterchangePipelineBase {
	///<summary>TexturePipeline</summary>
	public UInterchangeDatasmithTexturePipeline TexturePipeline;
	///<summary>MaterialPipeline</summary>
	public UInterchangeDatasmithMaterialPipeline MaterialPipeline;
	///<summary>MeshPipeline</summary>
	public UInterchangeDatasmithStaticMeshPipeline MeshPipeline;
	///<summary>LevelPipeline</summary>
	public UInterchangeDatasmithLevelPipeline LevelPipeline;
	///<summary>AnimationPipeline</summary>
	public UInterchangeGenericAnimationPipeline AnimationPipeline;
	///<summary>CommonMeshesProperties</summary>
	public UInterchangeGenericCommonMeshesProperties CommonMeshesProperties;
	///<summary>CommonSkeletalMeshesAndAnimationsProperties</summary>
	public UInterchangeGenericCommonSkeletalMeshesAndAnimationsProperties CommonSkeletalMeshesAndAnimationsProperties;
}
