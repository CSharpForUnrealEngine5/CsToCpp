namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Landscape.h")]
public partial class ALandscape : ALandscapeProxy {
	public static UClass StaticClass() {return default;}
	///<summary>RenderHeightmap</summary>
	public void RenderHeightmap(FTransform InWorldTransform,FBox2D InExtents,UTextureRenderTarget2D OutRenderTarget) {}
	///<summary>Use Nanite to render landscape as a mesh on supported platforms.</summary>
	public bool bEnableNanite;
	///<summary>LOD level of the landscape when generating the Nanite mesh. Mostly there for debug reasons, since Nanite is meant to allow high density meshes, we want to use 0 most of the times.</summary>
	public int NaniteLODIndex;
	///<summary>Landscape actor has authority on default streaming behavior for new actors : LandscapeStreamingProxies &amp; LandscapeSplineActors</summary>
	public bool bAreNewLandscapeActorsSpatiallyLoaded;
	///<summary>If true, LandscapeStreamingProxy actors have the grid size included in their name, for backward compatibility we also check the AWorldSettings::bIncludeGridSizeInNameForPartitionedActors</summary>
	public bool bIncludeGridSizeInNameForLandscapeActors;
	///<summary>bCanHaveLayersContent</summary>
	public bool bCanHaveLayersContent;
	///<summary>* If true, WorldPartitionLandscapeSplineMeshesBuilder is responsible of generating partitioned actors of type ALandscapeSplineMeshesActor that will contain all landscape spline/controlpoints static meshes.</summary>
	public bool bUseGeneratedLandscapeSplineMeshesActors;
	///<summary>Target Landscape Layer for Landscape Splines</summary>
	public FGuid LandscapeSplinesTargetLayerGuid;
	///<summary>bEnableEditorLayersTick</summary>
	public bool bEnableEditorLayersTick;
	///<summary>LandscapeLayers</summary>
	public TArray<FLandscapeLayer> LandscapeLayers;
	///<summary>HeightmapRTList</summary>
	public TArray<UTextureRenderTarget2D> HeightmapRTList;
	///<summary>WeightmapRTList</summary>
	public TArray<UTextureRenderTarget2D> WeightmapRTList;
	///<summary>List of textures that are not fully streamed in yet (updated every frame to track textures that have finished streaming in)</summary>
	public TArray<TWeakObjectPtr<UTexture2D>> TrackedStreamingInTextures;
	///<summary>Components affected by landscape splines (used to partially clear Layer Reserved for Splines)</summary>
	public TSet<ULandscapeComponent> LandscapeSplinesAffectedComponents;
	///<summary>bLandscapeLayersAreInitialized</summary>
	public bool bLandscapeLayersAreInitialized;
	///<summary>bLandscapeLayersAreUsingLocalMerge</summary>
	public bool bLandscapeLayersAreUsingLocalMerge;
	///<summary>WasCompilingShaders</summary>
	public bool WasCompilingShaders;
	///<summary>LayerContentUpdateModes</summary>
	public uint LayerContentUpdateModes;
	///<summary>bSplineLayerUpdateRequested</summary>
	public bool bSplineLayerUpdateRequested;
}
