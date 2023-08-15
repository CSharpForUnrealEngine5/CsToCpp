namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyComponent.h")]
public partial class UWaterBodyComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Returns body&#39;s collision components</summary>
	public virtual TArray<UPrimitiveComponent> GetCollisionComponents(bool bInOnlyEnabledComponents/*=true*/) { return default; }
	///<summary>Retrieves the list of primitive components that this water body uses when not being rendered by the water mesh (e.g. the static mesh component used when WaterMeshOverride is specified)</summary>
	public virtual TArray<UPrimitiveComponent> GetStandardRenderableComponents() { return default; }
	///<summary>Returns River to lake transition material instance (For internal use. Please use AWaterBodyRiver instead.)</summary>
	public virtual UMaterialInstanceDynamic GetRiverToLakeTransitionMaterialInstance() { return default; }
	///<summary>Returns River to ocean transition material instance (For internal use. Please use AWaterBodyRiver instead.)</summary>
	public virtual UMaterialInstanceDynamic GetRiverToOceanTransitionMaterialInstance() { return default; }
	///<summary>Returns the WaterBodyActor who owns this component</summary>
	public AWaterBody GetWaterBodyActor() { return default; }
	///<summary>Returns water spline component</summary>
	public UWaterSplineComponent GetWaterSpline() { return default; }
	///<summary>GetWaterWaves</summary>
	public UWaterWavesBase GetWaterWaves() { return default; }
	///<summary>Returns water material</summary>
	public UMaterialInterface GetWaterMaterial() { return default; }
	///<summary>Returns water MID</summary>
	public UMaterialInstanceDynamic GetWaterMaterialInstance() { return default; }
	///<summary>Returns water LOD MID</summary>
	public UMaterialInstanceDynamic GetWaterLODMaterialInstance() { return default; }
	///<summary>Returns under water post process MID</summary>
	public UMaterialInstanceDynamic GetUnderwaterPostProcessMaterialInstance() { return default; }
	///<summary>Returns water info MID</summary>
	public UMaterialInstanceDynamic GetWaterInfoMaterialInstance() { return default; }
	///<summary>SetWaterAndUnderWaterPostProcessMaterial</summary>
	public void SetWaterAndUnderWaterPostProcessMaterial(UMaterialInterface InWaterMaterial,UMaterialInterface InUnderWaterPostProcessMaterial) {}
	///<summary>GetWaterSurfaceInfoAtLocation</summary>
	public void GetWaterSurfaceInfoAtLocation(FVector InLocation,FVector OutWaterSurfaceLocation,FVector OutWaterSurfaceNormal,FVector OutWaterVelocity,float OutWaterDepth,bool bIncludeDepth/*=false*/) {}
	///<summary>* Spline queries specific to metadata type</summary>
	public virtual float GetWaterVelocityAtSplineInputKey(float InKey) { return default; }
	///<summary>Gets the islands that influence this water body</summary>
	public TArray<AWaterBodyIsland> GetIslands() { return default; }
	///<summary>Gets the exclusion volume that influence this water body</summary>
	public TArray<AWaterBodyExclusionVolume> GetExclusionVolumes() { return default; }
	///<summary>OnWaterBodyChanged</summary>
	public void OnWaterBodyChanged(bool bShapeOrPositionChanged,bool bWeightmapSettingsChanged/*=false*/) {}
	///<summary>Returns the max height that this water body&#39;s waves can hit. Can be called regardless of whether the water body supports waves or not</summary>
	public float GetMaxWaveHeight() { return default; }
	///<summary>PhysicalMaterial</summary>
	public UPhysicalMaterial PhysicalMaterial;
	///<summary>Water depth at which waves start being attenuated.</summary>
	public float TargetWaveMaskDepth;
	///<summary>Offset added to the automatically calculated max wave height bounds. Use this in case the automatically calculated max height bounds don&#39;t match your waves. This can happen if the water surface is manually altered through World Position Offset or other means.</summary>
	public float MaxWaveHeightOffset;
	///<summary>Post process settings to apply when the camera goes underwater (only available when bGenerateCollisions is true because collisions are needed to detect if it&#39;s under water).</summary>
	public FUnderwaterPostProcessSettings UnderwaterPostProcessSettings;
	///<summary>CurveSettings</summary>
	public FWaterCurveSettings CurveSettings;
	///<summary>WaterMaterial</summary>
	public UMaterialInterface WaterMaterial;
	///<summary>WaterHLODMaterial</summary>
	public UMaterialInterface WaterHLODMaterial;
	///<summary>WaterLODMaterial</summary>
	public UMaterialInterface WaterLODMaterial;
	///<summary>Post process material to apply when the camera goes underwater (only available when bGenerateCollisions is true because collisions are needed to detect if it&#39;s under water).</summary>
	public UMaterialInterface UnderwaterPostProcessMaterial;
	///<summary>WaterInfoMaterial</summary>
	public UMaterialInterface WaterInfoMaterial;
	///<summary>WaterHeightmapSettings</summary>
	public FWaterBodyHeightmapSettings WaterHeightmapSettings;
	///<summary>LayerWeightmapSettings</summary>
	public TMap<FName,FWaterBodyWeightmapSettings> LayerWeightmapSettings;
	///<summary>ShapeDilation</summary>
	public float ShapeDilation;
	///<summary>The distance above the surface of the water where collision checks should still occur. Useful if the post process effect is not activating under really high waves.</summary>
	public float CollisionHeightOffset;
	///<summary>If enabled, landscape will be deformed based on this water body placed on top of it and landscape height will be considered when determining water depth at runtime</summary>
	public bool bAffectsLandscape;
	///<summary>Unique Id for accessing (wave, ... ) data in GPU buffers</summary>
	public int WaterBodyIndex;
	///<summary>WaterMeshOverride</summary>
	public UStaticMesh WaterMeshOverride;
	///<summary>When this is set to true, the water mesh will always generate tiles for this water body.</summary>
	public bool bAlwaysGenerateWaterMeshTiles;
	///<summary>Higher number is higher priority. If two water bodies overlap and they don&#39;t have a transition material specified, this will be used to determine which water body to use the material from. Valid range is -8192 to 8191</summary>
	public int OverlapMaterialPriority;
	///<summary>WaterSplineMetadata</summary>
	public UWaterSplineMetadata WaterSplineMetadata;
	///<summary>WaterMID</summary>
	public UMaterialInstanceDynamic WaterMID;
	///<summary>WaterLODMID</summary>
	public UMaterialInstanceDynamic WaterLODMID;
	///<summary>UnderwaterPostProcessMID</summary>
	public UMaterialInstanceDynamic UnderwaterPostProcessMID;
	///<summary>WaterInfoMID</summary>
	public UMaterialInstanceDynamic WaterInfoMID;
	///<summary>Islands in this water body</summary>
	public TArray<TSoftObjectPtr<AWaterBodyIsland>> WaterBodyIslands;
	///<summary>WaterBodyExclusionVolumes</summary>
	public TArray<TSoftObjectPtr<AWaterBodyExclusionVolume>> WaterBodyExclusionVolumes;
	///<summary>Landscape</summary>
	public TWeakObjectPtr<ALandscapeProxy> Landscape;
	///<summary>OwningWaterZone</summary>
	public TSoftObjectPtr<AWaterZone> OwningWaterZone;
	///<summary>WaterZoneOverride</summary>
	public TSoftObjectPtr<AWaterZone> WaterZoneOverride;
	///<summary>CurrentPostProcessSettings</summary>
	public FPostProcessSettings CurrentPostProcessSettings;
	///<summary>The navigation area class that will be generated on nav mesh</summary>
	public UClass WaterNavAreaClass;
	///<summary>If the Water Material assigned to this component has Fixed Depth enabled, this is the depth that is passed.</summary>
	public double FixedWaterDepth;
	///<summary>Islands_DEPRECATED</summary>
	public TArray<TLazyObjectPtr<AWaterBodyIsland>> Islands_DEPRECATED;
	///<summary>ExclusionVolumes_DEPRECATED</summary>
	public TArray<TLazyObjectPtr<AWaterBodyExclusionVolume>> ExclusionVolumes_DEPRECATED;
	///<summary>bFillCollisionUnderWaterBodiesForNavmesh_DEPRECATED</summary>
	public bool bFillCollisionUnderWaterBodiesForNavmesh_DEPRECATED;
	///<summary>CollisionProfileName_DEPRECATED</summary>
	public FName CollisionProfileName_DEPRECATED;
	///<summary>bGenerateCollisions_DEPRECATED</summary>
	public bool bGenerateCollisions_DEPRECATED;
	///<summary>bCanAffectNavigation_DEPRECATED</summary>
	public bool bCanAffectNavigation_DEPRECATED;
	///<summary>bOverrideWaterMesh_DEPRECATED</summary>
	public bool bOverrideWaterMesh_DEPRECATED;
}
