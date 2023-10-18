namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeDatasmithPipeline.h")]
public partial class UInterchangeDatasmithPipeline : UInterchangePipelineBase {
	public static UClass StaticClass() {return default;}
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
