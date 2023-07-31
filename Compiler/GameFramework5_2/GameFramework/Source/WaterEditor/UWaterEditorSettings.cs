#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the editor settings for the Water plugin.</summary>
[CppInclude("WaterEditorSettings.h")]
public partial class UWaterEditorSettings : UDeveloperSettings {
	///<summary>The texture group to use for generated textures such as the combined veloctiy and height texture</summary>
	public TextureGroup TextureGroupForGeneratedTextures;
	///<summary>Maximum size of the water velocity/height texture for a WaterZoneActor</summary>
	public int MaxWaterVelocityAndHeightTextureSize;
	///<summary>Scale factor for visualizing water velocity</summary>
	public float VisualizeWaterVelocityScale;
	///<summary>Material Parameter Collection for everything landscape-related</summary>
	public TSoftObjectPtr<UMaterialParameterCollection> LandscapeMaterialParameterCollection;
	///<summary>Default values for base WaterMesh actor</summary>
	public FWaterZoneActorDefaults WaterZoneActorDefaults;
	///<summary>Default values for base WaterBodyRiver actor</summary>
	public FWaterBodyRiverDefaults WaterBodyRiverDefaults;
	///<summary>Default values for base WaterBodyLake actor</summary>
	public FWaterBodyLakeDefaults WaterBodyLakeDefaults;
	///<summary>Default values for base WaterBodyOcean actor</summary>
	public FWaterBodyOceanDefaults WaterBodyOceanDefaults;
	///<summary>Default values for base WaterBodyCustom actor</summary>
	public FWaterBodyCustomDefaults WaterBodyCustomDefaults;
	///<summary>Default values for base WaterBodyIsland actor</summary>
	public FWaterBodyIslandDefaults WaterBodyIslandDefaults;
	///<summary>For landscape-affecting water bodies, allows the landscape to be updated when the water body&#39;s shape is modified interactively (e.g. when dragging a spline point). Set to false if the performance when editing a water body gets too bad (the landscape will be properly updated when the dragging operation is done).</summary>
	public bool bUpdateLandscapeDuringInteractiveChanges;
	///<summary>Allows the water mesh to be updated when the water body&#39;s shape is modified interactively (e.g. when dragging a spline point). Set to false if the performance when editing a water body gets too bad (the water mesh will be properly updated when the dragging operation is done).</summary>
	public bool bUpdateWaterMeshDuringInteractiveChanges;
	///<summary>Class of the water zone to be used</summary>
	public FSoftClassPath WaterZoneClassPath;
	///<summary>Class of the water brush to be used in landscape</summary>
	public FSoftClassPath WaterManagerClassPath;
	///<summary>DefaultBrushAngleFalloffMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultBrushAngleFalloffMaterial;
	///<summary>DefaultBrushIslandFalloffMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultBrushIslandFalloffMaterial;
	///<summary>DefaultBrushWidthFalloffMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultBrushWidthFalloffMaterial;
	///<summary>DefaultBrushWeightmapMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultBrushWeightmapMaterial;
	///<summary>DefaultCacheDistanceFieldCacheMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultCacheDistanceFieldCacheMaterial;
	///<summary>DefaultCompositeWaterBodyTextureMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultCompositeWaterBodyTextureMaterial;
	///<summary>DefaultJumpFloodStepMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultJumpFloodStepMaterial;
	///<summary>DefaultBlurEdgesMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultBlurEdgesMaterial;
	///<summary>DefaultFindEdgesMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultFindEdgesMaterial;
	///<summary>DefaultDrawCanvasMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultDrawCanvasMaterial;
	///<summary>DefaultRenderRiverSplineDepthsMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultRenderRiverSplineDepthsMaterial;
}
