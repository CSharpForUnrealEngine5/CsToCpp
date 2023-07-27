#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
public partial struct FMeshProxySettings {
// MeshProxySettings
	public int ScreenSize;
	public float VoxelSize;
	public FMaterialProxySettings MaterialSettings;
	public int TextureWidth_DEPRECATED;
	public int TextureHeight_DEPRECATED;
	public bool bExportNormalMap_DEPRECATED;
	public bool bExportMetallicMap_DEPRECATED;
	public bool bExportRoughnessMap_DEPRECATED;
	public bool bExportSpecularMap_DEPRECATED;
	public bool bBakeVertexData_DEPRECATED;
	public bool bGenerateNaniteEnabledMesh_DEPRECATED;
	public float NaniteProxyTrianglePercent_DEPRECATED;
	public float MergeDistance;
	public FColor UnresolvedGeometryColor;
	public float MaxRayCastDist;
	public float HardAngleThreshold;
	public int LightMapResolution;
	public EProxyNormalComputationMethod NormalCalculationMethod;
	public ELandscapeCullingPrecision LandscapeCullingPrecision;
	public bool bCalculateCorrectLODModel;
	public bool bOverrideVoxelSize;
	public bool bOverrideTransferDistance;
	public bool bUseHardAngleThreshold;
	public bool bComputeLightMapResolution;
	public bool bRecalculateNormals;
	public bool bUseLandscapeCulling;
	public bool bSupportRayTracing;
	public bool bAllowDistanceField;
	public bool bReuseMeshLightmapUVs;
	public bool bGroupIdenticalMeshesForBaking;
	public bool bCreateCollision;
	public bool bAllowVertexColors;
	public bool bGenerateLightmapUVs;
	public FMeshNaniteSettings NaniteSettings;
}
