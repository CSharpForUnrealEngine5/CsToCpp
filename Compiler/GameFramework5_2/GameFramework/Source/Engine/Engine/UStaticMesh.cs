#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMesh.h")]
///<summary>A StaticMesh is a piece of geometry that consists of a static set of polygons.</summary>
public partial class UStaticMesh : UStreamableRenderAsset {
// StaticMesh
	public TArray<FStaticMeshSourceModel> SourceModels;
	public FStaticMeshSourceModel HiResSourceModel;
	public FMeshSectionInfoMap SectionInfoMap;
	public FMeshSectionInfoMap OriginalSectionInfoMap;
	public string LODGroup;
	public FPerPlatformInt NumStreamedLODs;
	public int ImportVersion;
	public TArray<FMaterialRemapIndex> MaterialRemapIndexPerImportVersion;
	public int LightmapUVVersion;
	public bool bAutoComputeLODScreenSize;
	public TArray<UMaterialInterface> Materials_DEPRECATED;
	public FMeshNaniteSettings NaniteSettings;
	public bool IsLODScreenSizeAutoComputed() { return default; }
	public FPerQualityLevelInt MinQualityLevelLOD;
	public void GetMinimumLODForQualityLevels(TMap<string,int> QualityLevelMinimumLODs) {}
	public int GetMinimumLODForQualityLevel(string QualityLevel) { return default; }
	public void SetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default/*=-1*/) {}
	public void GetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default) {}
	public FPerPlatformInt MinLOD;
	public void GetMinimumLODForPlatforms(TMap<string,int> PlatformMinimumLODs) {}
	public int GetMinimumLODForPlatform(string PlatformName) { return default; }
	public void SetMinimumLODForPlatforms(TMap<string,int> PlatformMinimumLODs) {}
	public void SetMinimumLODForPlatform(string PlatformName,int InMinLOD) {}
	public TArray<FStaticMaterial> StaticMaterials;
	public TArray<FStaticMaterial> GetStaticMaterials() { return default; }
	public void SetStaticMaterials(TArray<FStaticMaterial> InStaticMaterials) {}
	public float LightmapUVDensity;
	public int LightMapResolution;
	public int LightMapCoordinateIndex;
	public float DistanceFieldSelfShadowBias;
	public UBodySetup BodySetup;
	public int LODForCollision;
	public bool bGenerateMeshDistanceField;
	public bool bStripComplexCollisionForConsole_DEPRECATED;
	public bool bHasNavigationData;
	public bool bSupportUniformlyDistributedSampling;
	public bool bSupportPhysicalMaterialMasks;
	public bool bSupportRayTracing;
	public bool bDoFastBuild;
	public bool bIsBuiltAtRuntime_DEPRECATED;
	public bool bAllowCPUAccess;
	public bool bSupportGpuUniformlyDistributedSampling;
	public UAssetImportData AssetImportData;
	public string SourceFilePath_DEPRECATED;
	public string SourceFileTimestamp_DEPRECATED;
	public UThumbnailInfo ThumbnailInfo;
	public FAssetEditorOrbitCameraPosition EditorCameraPosition;
	public bool bCustomizedCollision;
	public TArray<UStaticMeshSocket> Sockets;
	public FVector PositiveBoundsExtension;
	public FVector NegativeBoundsExtension;
	public FBoxSphereBounds ExtendedBounds;
	public int ElementToIgnoreForTexFactor;
	public TArray<UAssetUserData> AssetUserData;
	public UObject EditableMesh_DEPRECATED;
	public UStaticMesh ComplexCollisionMesh;
	public UObject CreateStaticMeshDescription(UObject Outer/*=nullptr*/) { return default; }
	public void BuildFromStaticMeshDescriptions(TArray<UObject> StaticMeshDescriptions,bool bBuildSimpleCollision/*=false*/,bool bFastBuild/*=true*/) {}
	public UObject GetStaticMeshDescription(int LODIndex) { return default; }
	public UNavCollisionBase NavCollision;
	public void SetNumSourceModels(int Num) {}
	public int GetNumTriangles(int LODIndex) { return default; }
	public int GetNumLODs() { return default; }
	public FBoxSphereBounds GetBounds() { return default; }
	public FBox GetBoundingBox() { return default; }
	public int GetNumSections(int InLOD) { return default; }
	public UObject GetMaterial(int MaterialIndex) { return default; }
	public string AddMaterial(UObject Material) { return default; }
	public int GetMaterialIndex(string MaterialSlotName) { return default; }
	public void AddSocket(UObject Socket) {}
	public UObject FindSocket(string InSocketName) { return default; }
	public void RemoveSocket(UObject Socket) {}
	public TArray<UObject> GetSocketsByTag(string InSocketTag) { return default; }
	public void SetMaterial(int MaterialIndex,UObject NewMaterial) {}
}
