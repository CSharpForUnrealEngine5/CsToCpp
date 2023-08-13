namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineDeferredPasses.h")]
public partial class UMoviePipelineDeferredPassBase : UMoviePipelineImagePassBase {
	public static UClass StaticClass() {return default;}
	///<summary>Should multiple temporal/spatial samples accumulate the alpha channel? This requires r.PostProcessing.PropagateAlpha</summary>
	public bool bAccumulatorIncludesAlpha;
	///<summary>Certain passes don&#39;t support post-processing effects that blend pixels together. These include effects like</summary>
	public bool bDisableMultisampleEffects;
	///<summary>Should the additional post-process materials write out to a 32-bit render target instead of 16-bit?</summary>
	public bool bUse32BitPostProcessMaterials;
	///<summary>An array of additional post-processing materials to run after the frame is rendered. Using this feature may add a notable amount of render time.</summary>
	public TArray<FMoviePipelinePostProcessPass> AdditionalPostProcessMaterials;
	///<summary>This can be turned off if you&#39;re only doing a stencil-layer based render and don&#39;t need the main non-stencil approach.</summary>
	public bool bRenderMainPass;
	///<summary>If true, an additional stencil layer will be rendered which contains all objects which do not belong to layers</summary>
	public bool bAddDefaultLayer;
	///<summary>For each layer in the array, the world will be rendered and then a stencil mask will clip all pixels not affected</summary>
	public TArray<FActorLayer> ActorLayers;
	///<summary>If the map you are working with is a World Partition map, you can specify Data layers instead of Actor Layers. If any</summary>
	public TArray<FSoftObjectPath> DataLayers;
	///<summary>While rendering, store an array of the non-null valid materials loaded from AdditionalPostProcessMaterials. Cleared on teardown.</summary>
	public TArray<UMaterialInterface> ActivePostProcessMaterials;
	///<summary>StencilLayerMaterial</summary>
	public UMaterialInterface StencilLayerMaterial;
}
