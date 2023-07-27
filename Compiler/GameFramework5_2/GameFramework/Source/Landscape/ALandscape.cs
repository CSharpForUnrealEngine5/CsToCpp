#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Landscape.h")]
public partial class ALandscape : ALandscapeProxy {
// Landscape
	public  void RenderHeightmap(FTransform InWorldTransform,FBox2D InExtents,UTextureRenderTarget2D OutRenderTarget) {}
	public bool bEnableNanite;
	public int NaniteLODIndex;
	public bool bAreNewLandscapeActorsSpatiallyLoaded;
	public bool bIncludeGridSizeInNameForLandscapeActors;
	public bool bCanHaveLayersContent;
	public bool bUseGeneratedLandscapeSplineMeshesActors;
	public FGuid LandscapeSplinesTargetLayerGuid;
	public bool bEnableEditorLayersTick;
	public TArray<FLandscapeLayer> LandscapeLayers;
	public TArray<UTextureRenderTarget2D> HeightmapRTList;
	public TArray<UTextureRenderTarget2D> WeightmapRTList;
	public TArray<TWeakObjectPtr<UTexture2D>> TrackedStreamingInTextures;
	public TSet<ULandscapeComponent> LandscapeSplinesAffectedComponents;
	public bool bLandscapeLayersAreInitialized;
	public bool bLandscapeLayersAreUsingLocalMerge;
	public bool WasCompilingShaders;
	public uint LayerContentUpdateModes;
	public bool bSplineLayerUpdateRequested;
}
