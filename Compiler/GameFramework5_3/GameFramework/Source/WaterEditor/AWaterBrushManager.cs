namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBrushManager.h")]
public partial class AWaterBrushManager : AWaterLandscapeBrush {
	public static UClass StaticClass() {return default;}
	///<summary>SceneCaptureComponent2D</summary>
	public USceneCaptureComponent2D SceneCaptureComponent2D;
	///<summary>JumpFloodComponent2D</summary>
	public UJumpFloodComponent2D JumpFloodComponent2D;
	///<summary>RTs</summary>
	public UTextureRenderTarget2D HeightmapRTA;
	///<summary>HeightmapRTB</summary>
	public UTextureRenderTarget2D HeightmapRTB;
	///<summary>JumpFloodRTA</summary>
	public UTextureRenderTarget2D JumpFloodRTA;
	///<summary>JumpFloodRTB</summary>
	public UTextureRenderTarget2D JumpFloodRTB;
	///<summary>DepthAndShapeRT</summary>
	public UTextureRenderTarget2D DepthAndShapeRT;
	///<summary>WaterDepthAndVelocityRT</summary>
	public UTextureRenderTarget2D WaterDepthAndVelocityRT;
	///<summary>CombinedVelocityAndHeightRTA</summary>
	public UTextureRenderTarget2D CombinedVelocityAndHeightRTA;
	///<summary>CombinedVelocityAndHeightRTB</summary>
	public UTextureRenderTarget2D CombinedVelocityAndHeightRTB;
	///<summary>LandscapeRTRef</summary>
	public UTextureRenderTarget2D LandscapeRTRef;
	///<summary>WeightmapRTA</summary>
	public UTextureRenderTarget2D WeightmapRTA;
	///<summary>WeightmapRTB</summary>
	public UTextureRenderTarget2D WeightmapRTB;
	///<summary>Brush materials</summary>
	public UMaterialInterface BrushAngleFalloffMaterial;
	///<summary>BrushWidthFalloffMaterial</summary>
	public UMaterialInterface BrushWidthFalloffMaterial;
	///<summary>DistanceFieldCacheMaterial</summary>
	public UMaterialInterface DistanceFieldCacheMaterial;
	///<summary>RenderRiverSplineDepthMaterial</summary>
	public UMaterialInterface RenderRiverSplineDepthMaterial;
	///<summary>TODO [jonathan.bard] : rename to DebugDistanceFieldMaterial and make it work :</summary>
	public UMaterialInterface DebugDistanceFieldMaterial;
	///<summary>WeightmapMaterial</summary>
	public UMaterialInterface WeightmapMaterial;
	///<summary>DrawCanvasMaterial</summary>
	public UMaterialInterface DrawCanvasMaterial;
	///<summary>CompositeWaterBodyTextureMaterial</summary>
	public UMaterialInterface CompositeWaterBodyTextureMaterial;
	///<summary>IslandFalloffMaterial</summary>
	public UMaterialInterface IslandFalloffMaterial;
	///<summary>JumpStepMaterial</summary>
	public UMaterialInterface JumpStepMaterial;
	///<summary>FindEdgesMaterial</summary>
	public UMaterialInterface FindEdgesMaterial;
	///<summary>BlurEdgesMaterial</summary>
	public UMaterialInterface BlurEdgesMaterial;
	///<summary>MIDs</summary>
	public UMaterialInstanceDynamic BrushAngleFalloffMID;
	///<summary>BrushWidthFalloffMID</summary>
	public UMaterialInstanceDynamic BrushWidthFalloffMID;
	///<summary>DistanceFieldCacheMID</summary>
	public UMaterialInstanceDynamic DistanceFieldCacheMID;
	///<summary>RiverSplineMIDs</summary>
	public TArray<UMaterialInstanceDynamic> RiverSplineMIDs;
	///<summary>DebugDistanceFieldMID</summary>
	public UMaterialInstanceDynamic DebugDistanceFieldMID;
	///<summary>WeightmapMID</summary>
	public UMaterialInstanceDynamic WeightmapMID;
	///<summary>DrawCanvasMID</summary>
	public UMaterialInstanceDynamic DrawCanvasMID;
	///<summary>CompositeWaterBodyTextureMID</summary>
	public UMaterialInstanceDynamic CompositeWaterBodyTextureMID;
	///<summary>IslandFalloffMID</summary>
	public UMaterialInstanceDynamic IslandFalloffMID;
	///<summary>MIDs End</summary>
	public TMap<UCurveFloat,FWaterBodyBrushCache> BrushCurveRTCache;
	///<summary>WorldSize</summary>
	public FVector WorldSize;
	///<summary>LandscapeRTRes</summary>
	public FIntPoint LandscapeRTRes;
	///<summary>LandscapeQuads</summary>
	public FIntPoint LandscapeQuads;
	///<summary>LandscapeTransform</summary>
	public FTransform LandscapeTransform;
	///<summary>ShowGradient</summary>
	public bool ShowGradient;
	///<summary>DistanceDivisor</summary>
	public float DistanceDivisor;
	///<summary>ShowDistance</summary>
	public bool ShowDistance;
	///<summary>ShowGrid</summary>
	public bool ShowGrid;
	///<summary>CanvasSegmentSize</summary>
	public float CanvasSegmentSize;
	///<summary>WaterClearHeight</summary>
	public float WaterClearHeight;
	///<summary>SplineMeshExtension</summary>
	public float SplineMeshExtension;
	///<summary>UseDynamicPreviewRT</summary>
	public bool UseDynamicPreviewRT;
	///<summary>DisableBrushTextureEffects</summary>
	public bool DisableBrushTextureEffects;
	///<summary>bNeedsForceUpdate</summary>
	public bool bNeedsForceUpdate;
	///<summary>FinalizeVelocityHeightMaterial_DEPRECATED</summary>
	public UMaterialInterface FinalizeVelocityHeightMaterial_DEPRECATED;
	///<summary>FinalizeVelocityHeightMID_DEPRECATED</summary>
	public UMaterialInstanceDynamic FinalizeVelocityHeightMID_DEPRECATED;
	///<summary>Debug Buttons</summary>
	public virtual void ForceUpdate() {}
	///<summary>SingleBlurStep</summary>
	public virtual void SingleBlurStep() {}
	///<summary>FindEdges</summary>
	public virtual void FindEdges() {}
	///<summary>SingleJumpStep</summary>
	public virtual void SingleJumpStep() {}
	///<summary>out</summary>
	public virtual void GetWaterCacheKey(AActor WaterBrush,UWaterBodyBrushCacheContainer ContainerObject,FWaterBodyBrushCache Value) {}
	///<summary>Sorts the water bodies in the order they should be rendered when rendering the water brush</summary>
	public void SortWaterBodiesForBrushRender(TArray<AWaterBody> InOutWaterBodies) {}
	///<summary>SetupDefaultMaterials</summary>
	public void SetupDefaultMaterials() {}
}
