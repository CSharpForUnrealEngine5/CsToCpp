#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyActor.h")]
///<summary>@todo_water: Remove Blueprintable</summary>
public partial class AWaterBody : AActor {
// WaterBody
	public EWaterBodyType GetWaterBodyType() { return default; }
	public UObject GetWaterSpline() { return default; }
	public void SetWaterWaves(UObject InWaterWaves) {}
	public UObject GetWaterBodyComponent() { return default; }
	public UWaterSplineComponent SplineComp;
	public UWaterSplineMetadata WaterSplineMetadata;
	public UWaterBodyComponent WaterBodyComponent;
	public int WaterBodyIndex;
	public EWaterBodyType WaterBodyType;
	public UWaterWavesBase WaterWaves;
	public UObject GetRiverToLakeTransitionMaterialInstance() { return default; }
	public UObject GetRiverToOceanTransitionMaterialInstance() { return default; }
	public void SetWaterMaterial(UObject InMaterial) {}
	public UObject GetWaterMaterialInstance() { return default; }
	public float GetWaterVelocityAtSplineInputKey(float InKey) { return default; }
	public FVector GetWaterVelocityVectorAtSplineInputKey(float InKey) { return default; }
	public float GetAudioIntensityAtSplineInputKey(float InKey) { return default; }
	public TArray<UObject> GetIslands() { return default; }
	public TArray<UObject> GetExclusionVolumes() { return default; }
	public void OnWaterBodyChanged(bool bShapeOrPositionChanged,bool bWeightmapSettingsChanged/*=false*/) {}
	public UPhysicalMaterial PhysicalMaterial_DEPRECATED;
	public float TargetWaveMaskDepth_DEPRECATED;
	public float MaxWaveHeightOffset_DEPRECATED;
	public bool bFillCollisionUnderWaterBodiesForNavmesh_DEPRECATED;
	public FUnderwaterPostProcessSettings UnderwaterPostProcessSettings_DEPRECATED;
	public FWaterCurveSettings CurveSettings_DEPRECATED;
	public UMaterialInterface WaterMaterial_DEPRECATED;
	public UMaterialInterface UnderwaterPostProcessMaterial_DEPRECATED;
	public FLandmassTerrainCarvingSettings TerrainCarvingSettings_DEPRECATED;
	public FWaterBodyHeightmapSettings WaterHeightmapSettings_DEPRECATED;
	public TMap<string,FWaterBodyWeightmapSettings> LayerWeightmapSettings_DEPRECATED;
	public bool bAffectsLandscape_DEPRECATED;
	public bool bGenerateCollisions_DEPRECATED;
	public bool bOverrideWaterMesh_DEPRECATED;
	public UStaticMesh WaterMeshOverride_DEPRECATED;
	public int OverlapMaterialPriority_DEPRECATED;
	public string CollisionProfileName_DEPRECATED;
	public UMaterialInstanceDynamic WaterMID_DEPRECATED;
	public UMaterialInstanceDynamic UnderwaterPostProcessMID_DEPRECATED;
	public TArray<TLazyObjectPtr<AWaterBodyIsland>> Islands_DEPRECATED;
	public TArray<TLazyObjectPtr<AWaterBodyExclusionVolume>> ExclusionVolumes_DEPRECATED;
	public bool bCanAffectNavigation_DEPRECATED;
	public UClass WaterNavAreaClass_DEPRECATED;
	public float ShapeDilation_DEPRECATED;
}
