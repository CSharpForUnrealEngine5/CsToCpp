#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineDeferredPasses.h")]
public partial class UMoviePipelineDeferredPassBase : UMoviePipelineImagePassBase {
// MoviePipelineDeferredPassBase
	public bool bAccumulatorIncludesAlpha;
	public bool bDisableMultisampleEffects;
	public bool bUse32BitPostProcessMaterials;
	public TArray<FMoviePipelinePostProcessPass> AdditionalPostProcessMaterials;
	public bool bRenderMainPass;
	public bool bAddDefaultLayer;
	public TArray<FActorLayer> ActorLayers;
	public TArray<FSoftObjectPath> DataLayers;
	public TArray<UMaterialInterface> ActivePostProcessMaterials;
	public UMaterialInterface StencilLayerMaterial;
}
