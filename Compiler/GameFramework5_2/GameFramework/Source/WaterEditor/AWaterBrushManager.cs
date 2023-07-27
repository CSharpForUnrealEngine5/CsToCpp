#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBrushManager.h")]
public partial class AWaterBrushManager : AWaterLandscapeBrush {
// WaterBrushManager
	public USceneCaptureComponent2D SceneCaptureComponent2D;
	public UJumpFloodComponent2D JumpFloodComponent2D;
	public UTextureRenderTarget2D HeightmapRTA;
	public UTextureRenderTarget2D HeightmapRTB;
	public UTextureRenderTarget2D JumpFloodRTA;
	public UTextureRenderTarget2D JumpFloodRTB;
	public UTextureRenderTarget2D DepthAndShapeRT;
	public UTextureRenderTarget2D WaterDepthAndVelocityRT;
	public UTextureRenderTarget2D CombinedVelocityAndHeightRTA;
	public UTextureRenderTarget2D CombinedVelocityAndHeightRTB;
	public UTextureRenderTarget2D LandscapeRTRef;
	public UTextureRenderTarget2D WeightmapRTA;
	public UTextureRenderTarget2D WeightmapRTB;
	public UMaterialInterface BrushAngleFalloffMaterial;
	public UMaterialInterface BrushWidthFalloffMaterial;
	public UMaterialInterface DistanceFieldCacheMaterial;
	public UMaterialInterface RenderRiverSplineDepthMaterial;
	public UMaterialInterface DebugDistanceFieldMaterial;
	public UMaterialInterface WeightmapMaterial;
	public UMaterialInterface DrawCanvasMaterial;
	public UMaterialInterface CompositeWaterBodyTextureMaterial;
	public UMaterialInterface IslandFalloffMaterial;
	public UMaterialInterface JumpStepMaterial;
	public UMaterialInterface FindEdgesMaterial;
	public UMaterialInterface BlurEdgesMaterial;
	public UMaterialInstanceDynamic BrushAngleFalloffMID;
	public UMaterialInstanceDynamic BrushWidthFalloffMID;
	public UMaterialInstanceDynamic DistanceFieldCacheMID;
	public TArray<UMaterialInstanceDynamic> RiverSplineMIDs;
	public UMaterialInstanceDynamic DebugDistanceFieldMID;
	public UMaterialInstanceDynamic WeightmapMID;
	public UMaterialInstanceDynamic DrawCanvasMID;
	public UMaterialInstanceDynamic CompositeWaterBodyTextureMID;
	public UMaterialInstanceDynamic IslandFalloffMID;
	public TMap<UCurveFloat,FWaterBodyBrushCache> BrushCurveRTCache;
	public FVector WorldSize;
	public FIntPoint LandscapeRTRes;
	public FIntPoint LandscapeQuads;
	public FTransform LandscapeTransform;
	public bool ShowGradient;
	public float DistanceDivisor;
	public bool ShowDistance;
	public bool ShowGrid;
	public float CanvasSegmentSize;
	public float WaterClearHeight;
	public float SplineMeshExtension;
	public bool UseDynamicPreviewRT;
	public bool DisableBrushTextureEffects;
	public bool bNeedsForceUpdate;
	public UMaterialInterface FinalizeVelocityHeightMaterial_DEPRECATED;
	public UMaterialInstanceDynamic FinalizeVelocityHeightMID_DEPRECATED;
	public  void ForceUpdate() {}
	public  void SingleBlurStep() {}
	public  void FindEdges() {}
	public  void SingleJumpStep() {}
	public  void GetWaterCacheKey(AActor WaterBrush,UWaterBodyBrushCacheContainer ContainerObject,FWaterBodyBrushCache Value) {}
	public  void SortWaterBodiesForBrushRender(TArray<AWaterBody> InOutWaterBodies) {}
	public  void SetupDefaultMaterials() {}
}
