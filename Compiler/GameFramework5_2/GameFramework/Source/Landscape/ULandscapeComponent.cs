#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeComponent.h")]
public partial class ULandscapeComponent : UPrimitiveComponent {
// LandscapeComponent
	public int SectionBaseX;
	public int SectionBaseY;
	public int ComponentSizeQuads;
	public int SubsectionSizeQuads;
	public int NumSubsections;
	public UMaterialInterface OverrideMaterial;
	public UMaterialInterface OverrideHoleMaterial;
	public TArray<FLandscapeComponentMaterialOverride> OverrideMaterials_DEPRECATED;
	public UMaterialInstanceConstant MaterialInstance_DEPRECATED;
	public TArray<UMaterialInstanceConstant> MaterialInstances;
	public TArray<UMaterialInstanceDynamic> MaterialInstancesDynamic;
	public TArray<short> LODIndexToMaterialIndex;
	public UTexture2D XYOffsetmapTexture;
	public FVector4 WeightmapScaleBias;
	public float WeightmapSubsectionOffset;
	public FVector4 HeightmapScaleBias;
	public FBox CachedLocalBox;
	public TLazyObjectPtr<ULandscapeHeightfieldCollisionComponent> CollisionComponent_DEPRECATED;
	public ULandscapeHeightfieldCollisionComponent CollisionComponentRef;
	public bool bUserTriggeredChangeRequested;
	public bool bNaniteActive;
	public FGuid LightingGuid;
	public TMap<FGuid,FLandscapeLayerComponentData> LayersData;
	public TArray<ULandscapeWeightmapUsage> WeightmapTexturesUsage;
	public uint LayerUpdateFlagPerMode;
	public bool bPendingCollisionDataUpdate;
	public bool bPendingLayerCollisionDataUpdate;
	public UTexture2D HeightmapTexture;
	public TArray<FWeightmapLayerAllocationInfo> WeightmapLayerAllocations;
	public TArray<UTexture2D> WeightmapTextures;
	public TArray<FLandscapePerLODMaterialOverride> PerLODOverrideMaterials;
	public FGuid MapBuildDataId;
	public int CollisionMipLevel;
	public int SimpleCollisionMipLevel;
	public float NegativeZBoundsExtension;
	public float PositiveZBoundsExtension;
	public float StaticLightingResolution;
	public int ForcedLOD;
	public int LODBias;
	public FGuid StateId;
	public FGuid BakedTextureMaterialGuid;
	public FGuid LastBakedTextureMaterialGuid;
	public UTexture2D GIBakedBaseColorTexture;
	public TArray<FGuid> IrrelevantLights_DEPRECATED;
	public int LightingLODBias;
	public TArray<ULandscapeLayerInfoObject> LayerAllowList;
	public FLandscapeEditToolRenderData EditToolRenderData;
	public FGuid MobileDataSourceHash;
	public TMap<UMaterialInterface,short> MaterialPerLOD;
	public uint SplineHash;
	public uint PhysicalMaterialHash;
	public uint LastSavedPhysicalMaterialHash;
	public UMaterialInterface MobileMaterialInterface_DEPRECATED;
	public TArray<UMaterialInterface> MobileMaterialInterfaces;
	public TArray<UTexture2D> MobileWeightmapTextures;
	public TArray<UMaterialInstanceConstant> MobileCombinationMaterialInstances;
	public UMaterialInstanceConstant MobileCombinationMaterialInstance_DEPRECATED;
	public UObject GetMaterialInstanceDynamic(int InIndex) { return default; }
	public float EditorGetPaintLayerWeightAtLocation(FVector InLocation,UObject PaintLayer) { return default; }
	public float EditorGetPaintLayerWeightByNameAtLocation(FVector InLocation,string InPaintLayerName) { return default; }
	public void SetForcedLOD(int InForcedLOD) {}
	public void SetLODBias(int InLODBias) {}
}
