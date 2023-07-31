#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeComponent.h")]
public partial class ULandscapeComponent : UPrimitiveComponent {
	///<summary>X offset from global components grid origin (in quads)</summary>
	public int SectionBaseX;
	///<summary>Y offset from global components grid origin (in quads)</summary>
	public int SectionBaseY;
	///<summary>Total number of quads for this component, has to be &gt;0</summary>
	public int ComponentSizeQuads;
	///<summary>Number of quads for a subsection of the component. SubsectionSizeQuads+1 must be a power of two.</summary>
	public int SubsectionSizeQuads;
	///<summary>Number of subsections in X or Y axis</summary>
	public int NumSubsections;
	///<summary>OverrideMaterial</summary>
	public UMaterialInterface OverrideMaterial;
	///<summary>OverrideHoleMaterial</summary>
	public UMaterialInterface OverrideHoleMaterial;
	///<summary>OverrideMaterials_DEPRECATED</summary>
	public TArray<FLandscapeComponentMaterialOverride> OverrideMaterials_DEPRECATED;
	///<summary>MaterialInstance_DEPRECATED</summary>
	public UMaterialInstanceConstant MaterialInstance_DEPRECATED;
	///<summary>MaterialInstances</summary>
	public TArray<UMaterialInstanceConstant> MaterialInstances;
	///<summary>MaterialInstancesDynamic</summary>
	public TArray<UMaterialInstanceDynamic> MaterialInstancesDynamic;
	///<summary>Mapping between LOD and Material Index</summary>
	public TArray<short> LODIndexToMaterialIndex;
	///<summary>XYOffsetmap texture reference</summary>
	public UTexture2D XYOffsetmapTexture;
	///<summary>UV offset to component&#39;s weightmap data from component local coordinates</summary>
	public FVector4 WeightmapScaleBias;
	///<summary>U or V offset into the weightmap for the first subsection, in texture UV space</summary>
	public float WeightmapSubsectionOffset;
	///<summary>UV offset to Heightmap data from component local coordinates</summary>
	public FVector4 HeightmapScaleBias;
	///<summary>Cached local-space bounding box, created at heightmap update time</summary>
	public FBox CachedLocalBox;
	///<summary>CollisionComponent_DEPRECATED</summary>
	public TLazyObjectPtr<ULandscapeHeightfieldCollisionComponent> CollisionComponent_DEPRECATED;
	///<summary>Reference to associated collision component</summary>
	public ULandscapeHeightfieldCollisionComponent CollisionComponentRef;
	///<summary>Store</summary>
	public bool bUserTriggeredChangeRequested;
	///<summary>bNaniteActive</summary>
	public bool bNaniteActive;
	///<summary>Unique ID for this component, used for caching during distributed lighting</summary>
	public FGuid LightingGuid;
	///<summary>Edit Layers that have data for this component store it here</summary>
	public TMap<FGuid,FLandscapeLayerComponentData> LayersData;
	///<summary>Final layer data</summary>
	public TArray<ULandscapeWeightmapUsage> WeightmapTexturesUsage;
	///<summary>LayerUpdateFlagPerMode</summary>
	public uint LayerUpdateFlagPerMode;
	///<summary>bPendingCollisionDataUpdate</summary>
	public bool bPendingCollisionDataUpdate;
	///<summary>bPendingLayerCollisionDataUpdate</summary>
	public bool bPendingLayerCollisionDataUpdate;
	///<summary>Heightmap texture reference</summary>
	public UTexture2D HeightmapTexture;
	///<summary>List of layers, and the weightmap and channel they are stored</summary>
	public TArray<FWeightmapLayerAllocationInfo> WeightmapLayerAllocations;
	///<summary>Weightmap texture reference</summary>
	public TArray<UTexture2D> WeightmapTextures;
	///<summary>PerLODOverrideMaterials</summary>
	public TArray<FLandscapePerLODMaterialOverride> PerLODOverrideMaterials;
	///<summary>Uniquely identifies this component&#39;s built map data.</summary>
	public FGuid MapBuildDataId;
	///<summary>Heightfield mipmap used to generate collision</summary>
	public int CollisionMipLevel;
	///<summary>Heightfield mipmap used to generate simple collision</summary>
	public int SimpleCollisionMipLevel;
	///<summary>Allows overriding the landscape bounds. This is useful if you distort the landscape with world-position-offset, for example</summary>
	public float NegativeZBoundsExtension;
	///<summary>Allows overriding the landscape bounds. This is useful if you distort the landscape with world-position-offset, for example</summary>
	public float PositiveZBoundsExtension;
	///<summary>StaticLightingResolution overriding per component, default value 0 means no overriding</summary>
	public float StaticLightingResolution;
	///<summary>Forced LOD level to use when rendering</summary>
	public int ForcedLOD;
	///<summary>LOD level Bias to use when rendering</summary>
	public int LODBias;
	///<summary>StateId</summary>
	public FGuid StateId;
	///<summary>The Material Guid that used when baking, to detect material recompilations</summary>
	public FGuid BakedTextureMaterialGuid;
	///<summary>The Material Guid that last saved, to notify manual build operation to bake textures</summary>
	public FGuid LastBakedTextureMaterialGuid;
	///<summary>Pre-baked Base Color texture for use by distance field GI</summary>
	public UTexture2D GIBakedBaseColorTexture;
	///<summary>Legacy irrelevant lights</summary>
	public TArray<FGuid> IrrelevantLights_DEPRECATED;
	///<summary>LOD level Bias to use when lighting building via lightmass, -1 Means automatic LOD calculation based on ForcedLOD + LODBias</summary>
	public int LightingLODBias;
	///<summary>List of layers allowed to be painted on this component</summary>
	public TArray<ULandscapeLayerInfoObject> LayerAllowList;
	///<summary>Pointer to data shared with the render thread, used by the editor tools</summary>
	public FLandscapeEditToolRenderData EditToolRenderData;
	///<summary>Hash of source for mobile generated data. Used determine if we need to re-generate mobile pixel data.</summary>
	public FGuid MobileDataSourceHash;
	///<summary>Represent the chosen material for each LOD</summary>
	public TMap<UMaterialInterface,short> MaterialPerLOD;
	///<summary>SplineHash</summary>
	public uint SplineHash;
	///<summary>Represents hash for last PhysicalMaterialTask</summary>
	public uint PhysicalMaterialHash;
	///<summary>Represents last saved hash for PhysicalMaterialTask</summary>
	public uint LastSavedPhysicalMaterialHash;
	///<summary>MobileMaterialInterface_DEPRECATED</summary>
	public UMaterialInterface MobileMaterialInterface_DEPRECATED;
	///<summary>Material interfaces used for mobile</summary>
	public TArray<UMaterialInterface> MobileMaterialInterfaces;
	///<summary>Generated weightmap textures used for mobile. The first entry is also used for the normal map.</summary>
	public TArray<UTexture2D> MobileWeightmapTextures;
	///<summary>The editor needs to save out the combination MIC we&#39;ll use for mobile,</summary>
	public TArray<UMaterialInstanceConstant> MobileCombinationMaterialInstances;
	///<summary>MobileCombinationMaterialInstance_DEPRECATED</summary>
	public UMaterialInstanceConstant MobileCombinationMaterialInstance_DEPRECATED;
	///<summary>Gets the landscape material instance dynamic for this component</summary>
	public  UMaterialInstanceDynamic GetMaterialInstanceDynamic(int InIndex) { return default; }
	///<summary>Gets the landscape paint layer weight value at the given position using LandscapeLayerInfo . Returns 0 in case it fails.</summary>
	public  float EditorGetPaintLayerWeightAtLocation(FVector InLocation,ULandscapeLayerInfoObject PaintLayer) { return default; }
	///<summary>Gets the landscape paint layer weight value at the given position using layer name. Returns 0 in case it fails.</summary>
	public  float EditorGetPaintLayerWeightByNameAtLocation(FVector InLocation,string InPaintLayerName) { return default; }
	///<summary>SetForcedLOD</summary>
	public  void SetForcedLOD(int InForcedLOD) {}
	///<summary>SetLODBias</summary>
	public  void SetLODBias(int InLODBias) {}
}
