#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
///<summary>Mesh merging settings</summary>
public partial struct FMeshMergingSettings {
// MeshMergingSettings
	public int TargetLightMapResolution;
	public EUVOutput OutputUVs;
	public FMaterialProxySettings MaterialSettings;
	public int GutterSize;
	public EMeshLODSelectionType LODSelectionType;
	public int SpecificLOD;
	public bool bGenerateLightMapUV;
	public bool bComputedLightMapResolution;
	public bool bPivotPointAtZero;
	public bool bMergePhysicsData;
	public bool bMergeMeshSockets;
	public bool bMergeMaterials;
	public bool bCreateMergedMaterial;
	public bool bBakeVertexDataToMesh;
	public bool bUseVertexDataForBakingMaterial;
	public bool bUseTextureBinning;
	public bool bReuseMeshLightmapUVs;
	public bool bMergeEquivalentMaterials;
	public bool bUseLandscapeCulling;
	public bool bIncludeImposters;
	public bool bSupportRayTracing;
	public bool bAllowDistanceField;
	public FMeshNaniteSettings NaniteSettings;
	public bool bImportVertexColors_DEPRECATED;
	public bool bCalculateCorrectLODModel_DEPRECATED;
	public bool bExportNormalMap_DEPRECATED;
	public bool bExportMetallicMap_DEPRECATED;
	public bool bExportRoughnessMap_DEPRECATED;
	public bool bExportSpecularMap_DEPRECATED;
	public int MergedMaterialAtlasResolution_DEPRECATED;
	public int ExportSpecificLOD_DEPRECATED;
	public bool bGenerateNaniteEnabledMesh_DEPRECATED;
	public float NaniteFallbackTrianglePercent_DEPRECATED;
}
