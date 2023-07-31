#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@todo_water: Remove Blueprintable</summary>
[CppInclude("WaterBodyActor.h")]
public partial class AWaterBody : AActor {
	///<summary>Returns the type of body</summary>
	public  EWaterBodyType GetWaterBodyType() { return default; }
	///<summary>Returns water spline component</summary>
	public  UWaterSplineComponent GetWaterSpline() { return default; }
	///<summary>SetWaterWaves</summary>
	public  void SetWaterWaves(UWaterWavesBase InWaterWaves) {}
	///<summary>Returns the water body component</summary>
	public  UWaterBodyComponent GetWaterBodyComponent() { return default; }
	///<summary>The spline data attached to this water type.</summary>
	public UWaterSplineComponent SplineComp;
	///<summary>WaterSplineMetadata</summary>
	public UWaterSplineMetadata WaterSplineMetadata;
	///<summary>WaterBodyComponent</summary>
	public UWaterBodyComponent WaterBodyComponent;
	///<summary>Unique Id for accessing (wave, ... ) data in GPU buffers</summary>
	public int WaterBodyIndex;
	///<summary>WaterBodyType</summary>
	public EWaterBodyType WaterBodyType;
	///<summary>WaterWaves</summary>
	public UWaterWavesBase WaterWaves;
	///<summary>GetRiverToLakeTransitionMaterialInstance</summary>
	public  UMaterialInstanceDynamic GetRiverToLakeTransitionMaterialInstance() { return default; }
	///<summary>GetRiverToOceanTransitionMaterialInstance</summary>
	public  UMaterialInstanceDynamic GetRiverToOceanTransitionMaterialInstance() { return default; }
	///<summary>SetWaterMaterial</summary>
	public  void SetWaterMaterial(UMaterialInterface InMaterial) {}
	///<summary>GetWaterMaterialInstance</summary>
	public  UMaterialInstanceDynamic GetWaterMaterialInstance() { return default; }
	///<summary>GetWaterVelocityAtSplineInputKey</summary>
	public  float GetWaterVelocityAtSplineInputKey(float InKey) { return default; }
	///<summary>GetWaterVelocityVectorAtSplineInputKey</summary>
	public  FVector GetWaterVelocityVectorAtSplineInputKey(float InKey) { return default; }
	///<summary>GetAudioIntensityAtSplineInputKey</summary>
	public  float GetAudioIntensityAtSplineInputKey(float InKey) { return default; }
	///<summary>GetIslands</summary>
	public  TArray<AWaterBodyIsland> GetIslands() { return default; }
	///<summary>GetExclusionVolumes</summary>
	public  TArray<AWaterBodyExclusionVolume> GetExclusionVolumes() { return default; }
	///<summary>OnWaterBodyChanged</summary>
	public  void OnWaterBodyChanged(bool bShapeOrPositionChanged,bool bWeightmapSettingsChanged/*=false*/) {}
	///<summary>PhysicalMaterial_DEPRECATED</summary>
	public UPhysicalMaterial PhysicalMaterial_DEPRECATED;
	///<summary>TargetWaveMaskDepth_DEPRECATED</summary>
	public float TargetWaveMaskDepth_DEPRECATED;
	///<summary>MaxWaveHeightOffset_DEPRECATED</summary>
	public float MaxWaveHeightOffset_DEPRECATED;
	///<summary>bFillCollisionUnderWaterBodiesForNavmesh_DEPRECATED</summary>
	public bool bFillCollisionUnderWaterBodiesForNavmesh_DEPRECATED;
	///<summary>UnderwaterPostProcessSettings_DEPRECATED</summary>
	public FUnderwaterPostProcessSettings UnderwaterPostProcessSettings_DEPRECATED;
	///<summary>CurveSettings_DEPRECATED</summary>
	public FWaterCurveSettings CurveSettings_DEPRECATED;
	///<summary>WaterMaterial_DEPRECATED</summary>
	public UMaterialInterface WaterMaterial_DEPRECATED;
	///<summary>UnderwaterPostProcessMaterial_DEPRECATED</summary>
	public UMaterialInterface UnderwaterPostProcessMaterial_DEPRECATED;
	///<summary>TerrainCarvingSettings_DEPRECATED</summary>
	public FLandmassTerrainCarvingSettings TerrainCarvingSettings_DEPRECATED;
	///<summary>WaterHeightmapSettings_DEPRECATED</summary>
	public FWaterBodyHeightmapSettings WaterHeightmapSettings_DEPRECATED;
	///<summary>LayerWeightmapSettings_DEPRECATED</summary>
	public TMap<string,FWaterBodyWeightmapSettings> LayerWeightmapSettings_DEPRECATED;
	///<summary>bAffectsLandscape_DEPRECATED</summary>
	public bool bAffectsLandscape_DEPRECATED;
	///<summary>bGenerateCollisions_DEPRECATED</summary>
	public bool bGenerateCollisions_DEPRECATED;
	///<summary>bOverrideWaterMesh_DEPRECATED</summary>
	public bool bOverrideWaterMesh_DEPRECATED;
	///<summary>WaterMeshOverride_DEPRECATED</summary>
	public UStaticMesh WaterMeshOverride_DEPRECATED;
	///<summary>OverlapMaterialPriority_DEPRECATED</summary>
	public int OverlapMaterialPriority_DEPRECATED;
	///<summary>CollisionProfileName_DEPRECATED</summary>
	public string CollisionProfileName_DEPRECATED;
	///<summary>WaterMID_DEPRECATED</summary>
	public UMaterialInstanceDynamic WaterMID_DEPRECATED;
	///<summary>UnderwaterPostProcessMID_DEPRECATED</summary>
	public UMaterialInstanceDynamic UnderwaterPostProcessMID_DEPRECATED;
	///<summary>Islands_DEPRECATED</summary>
	public TArray<TLazyObjectPtr<AWaterBodyIsland>> Islands_DEPRECATED;
	///<summary>ExclusionVolumes_DEPRECATED</summary>
	public TArray<TLazyObjectPtr<AWaterBodyExclusionVolume>> ExclusionVolumes_DEPRECATED;
	///<summary>bCanAffectNavigation_DEPRECATED</summary>
	public bool bCanAffectNavigation_DEPRECATED;
	///<summary>WaterNavAreaClass_DEPRECATED</summary>
	public UClass WaterNavAreaClass_DEPRECATED;
	///<summary>ShapeDilation_DEPRECATED</summary>
	public float ShapeDilation_DEPRECATED;
}
