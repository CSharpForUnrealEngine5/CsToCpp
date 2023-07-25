#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSettings.h")]
///<summary>Implements the editor settings for the Water plugin.</summary>
public partial class UWaterEditorSettings : UDeveloperSettings {
// WaterEditorSettings
	public byte TextureGroupForGeneratedTextures;
	public int MaxWaterVelocityAndHeightTextureSize;
	public float VisualizeWaterVelocityScale;
	public TSoftObjectPtr<UMaterialParameterCollection> LandscapeMaterialParameterCollection;
	public FWaterZoneActorDefaults WaterZoneActorDefaults;
	public FWaterBodyRiverDefaults WaterBodyRiverDefaults;
	public FWaterBodyLakeDefaults WaterBodyLakeDefaults;
	public FWaterBodyOceanDefaults WaterBodyOceanDefaults;
	public FWaterBodyCustomDefaults WaterBodyCustomDefaults;
	public FWaterBodyIslandDefaults WaterBodyIslandDefaults;
	public bool bUpdateLandscapeDuringInteractiveChanges;
	public bool bUpdateWaterMeshDuringInteractiveChanges;
	public FSoftClassPath WaterZoneClassPath;
	public FSoftClassPath WaterManagerClassPath;
	public TSoftObjectPtr<UMaterialInterface> DefaultBrushAngleFalloffMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultBrushIslandFalloffMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultBrushWidthFalloffMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultBrushWeightmapMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultCacheDistanceFieldCacheMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultCompositeWaterBodyTextureMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultJumpFloodStepMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultBlurEdgesMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultFindEdgesMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultDrawCanvasMaterial;
	public TSoftObjectPtr<UMaterialInterface> DefaultRenderRiverSplineDepthsMaterial;
}
