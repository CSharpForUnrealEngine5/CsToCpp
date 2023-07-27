#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyComponent.h")]
public partial class UWaterBodyComponent : UPrimitiveComponent {
// WaterBodyComponent
	public  TArray<UPrimitiveComponent> GetCollisionComponents(bool bInOnlyEnabledComponents/*=true*/) { return default; }
	public  TArray<UPrimitiveComponent> GetStandardRenderableComponents() { return default; }
	public  UMaterialInstanceDynamic GetRiverToLakeTransitionMaterialInstance() { return default; }
	public  UMaterialInstanceDynamic GetRiverToOceanTransitionMaterialInstance() { return default; }
	public  AWaterBody GetWaterBodyActor() { return default; }
	public  UWaterSplineComponent GetWaterSpline() { return default; }
	public  UWaterWavesBase GetWaterWaves() { return default; }
	public  UMaterialInterface GetWaterMaterial() { return default; }
	public  UMaterialInstanceDynamic GetWaterMaterialInstance() { return default; }
	public  UMaterialInstanceDynamic GetWaterLODMaterialInstance() { return default; }
	public  UMaterialInstanceDynamic GetUnderwaterPostProcessMaterialInstance() { return default; }
	public  UMaterialInstanceDynamic GetWaterInfoMaterialInstance() { return default; }
	public  void SetWaterAndUnderWaterPostProcessMaterial(UMaterialInterface InWaterMaterial,UMaterialInterface InUnderWaterPostProcessMaterial) {}
	public  void GetWaterSurfaceInfoAtLocation(FVector InLocation,FVector OutWaterSurfaceLocation,FVector OutWaterSurfaceNormal,FVector OutWaterVelocity,float OutWaterDepth,bool bIncludeDepth/*=false*/) {}
	public  float GetWaterVelocityAtSplineInputKey(float InKey) { return default; }
	public  TArray<AWaterBodyIsland> GetIslands() { return default; }
	public  TArray<AWaterBodyExclusionVolume> GetExclusionVolumes() { return default; }
	public  void OnWaterBodyChanged(bool bShapeOrPositionChanged,bool bWeightmapSettingsChanged/*=false*/) {}
	public  float GetMaxWaveHeight() { return default; }
	public UPhysicalMaterial PhysicalMaterial;
	public float TargetWaveMaskDepth;
	public float MaxWaveHeightOffset;
	public FUnderwaterPostProcessSettings UnderwaterPostProcessSettings;
	public FWaterCurveSettings CurveSettings;
	public UMaterialInterface WaterMaterial;
	public UMaterialInterface WaterHLODMaterial;
	public UMaterialInterface WaterLODMaterial;
	public UMaterialInterface UnderwaterPostProcessMaterial;
	public UMaterialInterface WaterInfoMaterial;
	public FWaterBodyHeightmapSettings WaterHeightmapSettings;
	public TMap<string,FWaterBodyWeightmapSettings> LayerWeightmapSettings;
	public float ShapeDilation;
	public float CollisionHeightOffset;
	public bool bAffectsLandscape;
	public int WaterBodyIndex;
	public UStaticMesh WaterMeshOverride;
	public bool bAlwaysGenerateWaterMeshTiles;
	public int OverlapMaterialPriority;
	public UWaterSplineMetadata WaterSplineMetadata;
	public UMaterialInstanceDynamic WaterMID;
	public UMaterialInstanceDynamic WaterLODMID;
	public UMaterialInstanceDynamic UnderwaterPostProcessMID;
	public UMaterialInstanceDynamic WaterInfoMID;
	public TArray<TSoftObjectPtr<AWaterBodyIsland>> WaterBodyIslands;
	public TArray<TSoftObjectPtr<AWaterBodyExclusionVolume>> WaterBodyExclusionVolumes;
	public TWeakObjectPtr<ALandscapeProxy> Landscape;
	public TSoftObjectPtr<AWaterZone> OwningWaterZone;
	public TSoftObjectPtr<AWaterZone> WaterZoneOverride;
	public FPostProcessSettings CurrentPostProcessSettings;
	public UClass WaterNavAreaClass;
	public double FixedWaterDepth;
	public TArray<TLazyObjectPtr<AWaterBodyIsland>> Islands_DEPRECATED;
	public TArray<TLazyObjectPtr<AWaterBodyExclusionVolume>> ExclusionVolumes_DEPRECATED;
	public bool bFillCollisionUnderWaterBodiesForNavmesh_DEPRECATED;
	public string CollisionProfileName_DEPRECATED;
	public bool bGenerateCollisions_DEPRECATED;
	public bool bCanAffectNavigation_DEPRECATED;
	public bool bOverrideWaterMesh_DEPRECATED;
}
