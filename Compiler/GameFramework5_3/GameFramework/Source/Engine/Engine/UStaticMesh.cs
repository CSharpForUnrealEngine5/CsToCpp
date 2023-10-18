namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A StaticMesh is a piece of geometry that consists of a static set of polygons.</summary>
[CppInclude("Engine/StaticMesh.h")]
public partial class UStaticMesh : UStreamableRenderAsset {
	public static UClass StaticClass() {return default;}
	///<summary>SourceModels</summary>
	public TArray<FStaticMeshSourceModel> SourceModels;
	///<summary>HiResSourceModel</summary>
	public FStaticMeshSourceModel HiResSourceModel;
	///<summary>SectionInfoMap</summary>
	public FMeshSectionInfoMap SectionInfoMap;
	///<summary>OriginalSectionInfoMap</summary>
	public FMeshSectionInfoMap OriginalSectionInfoMap;
	///<summary>The LOD group to which this mesh belongs.</summary>
	public FName LODGroup;
	///<summary>If non-negative, specify the maximum number of streamed LODs. Only has effect if</summary>
	public FPerPlatformInt NumStreamedLODs;
	///<summary>The last import version</summary>
	public int ImportVersion;
	///<summary>MaterialRemapIndexPerImportVersion</summary>
	public TArray<FMaterialRemapIndex> MaterialRemapIndexPerImportVersion;
	///<summary>LightmapUVVersion</summary>
	public int LightmapUVVersion;
	///<summary>If true, the screen sizes at which LODs swap are computed automatically.</summary>
	public bool bAutoComputeLODScreenSize;
	///<summary>Materials used by this static mesh. Individual sections index in to this array.</summary>
	public TArray<UMaterialInterface> Materials_DEPRECATED;
	///<summary>Settings related to building Nanite data.</summary>
	public FMeshNaniteSettings NaniteSettings;
	///<summary>IsLODScreenSizeAutoComputed</summary>
	public bool IsLODScreenSizeAutoComputed() { return default; }
	///<summary>Allow more flexibility to set various values driven by the Scalability or Device Profile.</summary>
	public FPerQualityLevelInt MinQualityLevelLOD;
	///<summary>GetMinimumLODForQualityLevels</summary>
	public void GetMinimumLODForQualityLevels(TMap<FName,int> QualityLevelMinimumLODs) {}
	///<summary>GetMinimumLODForQualityLevel</summary>
	public int GetMinimumLODForQualityLevel(FName QualityLevel) { return default; }
	///<summary>Allow to override min lod quality levels on a staticMesh and it Default value (-1 value for Default dont override its value).</summary>
	public void SetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default/*=-1*/) {}
	///<summary>GetMinLODForQualityLevels</summary>
	public void GetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default) {}
	///<summary>MinLOD</summary>
	public FPerPlatformInt MinLOD;
	///<summary>GetMinimumLODForPlatforms</summary>
	public void GetMinimumLODForPlatforms(TMap<FName,int> PlatformMinimumLODs) {}
	///<summary>GetMinimumLODForPlatform</summary>
	public int GetMinimumLODForPlatform(FName PlatformName) { return default; }
	///<summary>SetMinimumLODForPlatforms</summary>
	public void SetMinimumLODForPlatforms(TMap<FName,int> PlatformMinimumLODs) {}
	///<summary>SetMinimumLODForPlatform</summary>
	public void SetMinimumLODForPlatform(FName PlatformName,int InMinLOD) {}
	///<summary>StaticMaterials</summary>
	public TArray<FStaticMaterial> StaticMaterials;
	///<summary>GetStaticMaterials</summary>
	public TArray<FStaticMaterial> GetStaticMaterials() { return default; }
	///<summary>SetStaticMaterials</summary>
	public void SetStaticMaterials(TArray<FStaticMaterial> InStaticMaterials) {}
	///<summary>LightmapUVDensity</summary>
	public float LightmapUVDensity;
	///<summary>The light map resolution</summary>
	public int LightMapResolution;
	///<summary>The light map coordinate index</summary>
	public int LightMapCoordinateIndex;
	///<summary>Useful for reducing self shadowing from distance field methods when using world position offset to animate the mesh&#39;s vertices.</summary>
	public float DistanceFieldSelfShadowBias;
	///<summary>BodySetup</summary>
	public UBodySetup BodySetup;
	///<summary>Specifies which mesh LOD to use for complex (per-poly) collision.</summary>
	public int LODForCollision;
	///<summary>Whether to generate a distance field for this mesh, which can be used by DistanceField Indirect Shadows.</summary>
	public bool bGenerateMeshDistanceField;
	///<summary>If true, strips unwanted complex collision data aka kDOP tree when cooking for consoles.</summary>
	public bool bStripComplexCollisionForConsole_DEPRECATED;
	///<summary>If true, mesh will have NavCollision property with additional data for navmesh generation and usage.</summary>
	public bool bHasNavigationData;
	///<summary>Mesh supports uniformly distributed sampling in constant time.</summary>
	public bool bSupportUniformlyDistributedSampling;
	///<summary>If true, complex collision data will store UVs and face remap table for use when performing</summary>
	public bool bSupportPhysicalMaterialMasks;
	///<summary>If true, a ray tracing acceleration structure will be built for this mesh and it may be used in ray tracing effects</summary>
	public bool bSupportRayTracing;
	///<summary>bDoFastBuild</summary>
	public bool bDoFastBuild;
	///<summary>bIsBuiltAtRuntime_DEPRECATED</summary>
	public bool bIsBuiltAtRuntime_DEPRECATED;
	///<summary>If true, will keep geometry data CPU-accessible in cooked builds, rather than uploading to GPU memory and releasing it from CPU memory.</summary>
	public bool bAllowCPUAccess;
	///<summary>If true, a GPU buffer containing required data for uniform mesh surface sampling will be created at load time.</summary>
	public bool bSupportGpuUniformlyDistributedSampling;
	///<summary>Importing data and options used for this mesh</summary>
	public UAssetImportData AssetImportData;
	///<summary>Path to the resource used to construct this static mesh</summary>
	public string SourceFilePath_DEPRECATED;
	///<summary>Date/Time-stamp of the file from the last import</summary>
	public string SourceFileTimestamp_DEPRECATED;
	///<summary>Information for thumbnail rendering</summary>
	public UThumbnailInfo ThumbnailInfo;
	///<summary>The stored camera position to use as a default for the static mesh editor</summary>
	public FAssetEditorOrbitCameraPosition EditorCameraPosition;
	///<summary>If the user has modified collision in any way or has custom collision imported. Used for determining if to auto generate collision on import</summary>
	public bool bCustomizedCollision;
	///<summary>Array of named socket locations, set up in editor and used as a shortcut instead of specifying</summary>
	public TArray<UStaticMeshSocket> Sockets;
	///<summary>PositiveBoundsExtension</summary>
	public FVector PositiveBoundsExtension;
	///<summary>NegativeBoundsExtension</summary>
	public FVector NegativeBoundsExtension;
	///<summary>ExtendedBounds</summary>
	public FBoxSphereBounds ExtendedBounds;
	///<summary>Index of an element to ignore while gathering streaming texture factors.</summary>
	public int ElementToIgnoreForTexFactor;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>EditableMesh_DEPRECATED</summary>
	public UObject EditableMesh_DEPRECATED;
	///<summary>ComplexCollisionMesh</summary>
	public UStaticMesh ComplexCollisionMesh;
	///<summary>Create an empty StaticMeshDescription object, to describe a static mesh at runtime</summary>
	public static UStaticMeshDescription CreateStaticMeshDescription(UObject Outer/*=nullptr*/) { return default; }
	///<summary>Builds static mesh LODs from the array of StaticMeshDescriptions passed in</summary>
	public void BuildFromStaticMeshDescriptions(TArray<UStaticMeshDescription> StaticMeshDescriptions,bool bBuildSimpleCollision/*=false*/,bool bFastBuild/*=true*/) {}
	///<summary>Return a new StaticMeshDescription referencing the MeshDescription of the given LOD</summary>
	public UStaticMeshDescription GetStaticMeshDescription(int LODIndex) { return default; }
	///<summary>NavCollision</summary>
	public UNavCollisionBase NavCollision;
	///<summary>SetNumSourceModels</summary>
	public void SetNumSourceModels(int Num) {}
	///<summary>Returns the number of triangles in the render data for the specified LOD.</summary>
	public int GetNumTriangles(int LODIndex) { return default; }
	///<summary>Returns the number of LODs used by the mesh.</summary>
	public int GetNumLODs() { return default; }
	///<summary>Returns the number of bounds of the mesh.</summary>
	public FBoxSphereBounds GetBounds() { return default; }
	///<summary>Returns the bounding box, in local space including bounds extension(s), of the StaticMesh asset</summary>
	public FBox GetBoundingBox() { return default; }
	///<summary>Returns number of Sections that this StaticMesh has, in the supplied LOD (LOD 0 is the highest)</summary>
	public int GetNumSections(int InLOD) { return default; }
	///<summary>Gets a Material given a Material Index and an LOD number</summary>
	public UMaterialInterface GetMaterial(int MaterialIndex) { return default; }
	///<summary>Adds a new material and return its slot name</summary>
	public FName AddMaterial(UMaterialInterface Material) { return default; }
	///<summary>Gets a Material index given a slot name</summary>
	public int GetMaterialIndex(FName MaterialSlotName) { return default; }
	///<summary>Add a socket object in this StaticMesh.</summary>
	public void AddSocket(UStaticMeshSocket Socket) {}
	///<summary>Find a socket object in this StaticMesh by name.</summary>
	public UStaticMeshSocket FindSocket(FName InSocketName) { return default; }
	///<summary>Remove a socket object in this StaticMesh by providing it&#39;s pointer. Use FindSocket() if needed.</summary>
	public void RemoveSocket(UStaticMeshSocket Socket) {}
	///<summary>Returns a list of sockets with the provided tag.</summary>
	public TArray<UStaticMeshSocket> GetSocketsByTag(string InSocketTag) { return default; }
	///<summary>Sets a Material given a Material Index</summary>
	public void SetMaterial(int MaterialIndex,UMaterialInterface NewMaterial) {}
}
