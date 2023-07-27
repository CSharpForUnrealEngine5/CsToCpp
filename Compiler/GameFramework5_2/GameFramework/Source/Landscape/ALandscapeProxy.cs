#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeProxy.h")]
public partial class ALandscapeProxy : APartitionActor {
// LandscapeProxy
	public ULandscapeSplinesComponent SplineComponent;
	public FGuid LandscapeGuid;
	public TArray<FLandscapePerLODMaterialOverride> PerLODOverrideMaterials;
	public TArray<FLandscapePerLODMaterialOverride> PreEditPerLODOverrideMaterials;
	public FIntPoint LandscapeSectionOffset;
	public int MaxLODLevel;
	public float LODDistanceFactor_DEPRECATED;
	public ELandscapeLODFalloff LODFalloff_DEPRECATED;
	public float ComponentScreenSizeToUseSubSections;
	public float LOD0ScreenSize;
	public float LOD0DistributionSetting;
	public float LODDistributionSetting;
	public int ExportLOD;
	public TArray<string> TargetDisplayOrderList;
	public ELandscapeLayerDisplayMode TargetDisplayOrder;
	public int StaticLightingLOD;
	public UPhysicalMaterial DefaultPhysMaterial;
	public float StreamingDistanceMultiplier;
	public UMaterialInterface LandscapeMaterial;
	public UMaterialInterface LandscapeHoleMaterial;
	public TArray<FLandscapeProxyMaterialOverride> LandscapeMaterialsOverride_DEPRECATED;
	public UMaterialInterface PreEditLandscapeMaterial;
	public UMaterialInterface PreEditLandscapeHoleMaterial;
	public bool bIsPerformingInteractiveActionOnLandscapeMaterialOverride;
	public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures;
	public bool bSetCreateRuntimeVirtualTextureVolumes;
	public bool bVirtualTextureRenderWithQuad;
	public bool bVirtualTextureRenderWithQuadHQ;
	public int VirtualTextureNumLods;
	public int VirtualTextureLodBias;
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
	public  void SetVirtualTextureRenderPassType(ERuntimeVirtualTextureMainPassType InType) {}
	public float NegativeZBoundsExtension;
	public float PositiveZBoundsExtension;
	public TArray<ULandscapeComponent> LandscapeComponents;
	public TArray<ULandscapeHeightfieldCollisionComponent> CollisionComponents;
	public TArray<UHierarchicalInstancedStaticMeshComponent> FoliageComponents;
	public ULandscapeNaniteComponent NaniteComponent;
	public bool bHasLandscapeGrass;
	public float StaticLightingResolution;
	public bool CastShadow;
	public bool bCastDynamicShadow;
	public bool bCastStaticShadow;
	public bool bCastContactShadow;
	public bool bCastFarShadow;
	public bool bCastHiddenShadow;
	public bool bCastShadowAsTwoSided;
	public bool bAffectDistanceFieldLighting;
	public FLightingChannels LightingChannels;
	public bool bUseMaterialPositionOffsetInStaticLighting;
	public bool bRenderCustomDepth;
	public ERendererStencilMask CustomDepthStencilWriteMask;
	public int CustomDepthStencilValue;
	public float LDMaxDrawDistance;
	public FLightmassPrimitiveSettings LightmassSettings;
	public int CollisionMipLevel;
	public int SimpleCollisionMipLevel;
	public FBodyInstance BodyInstance;
	public bool bGenerateOverlapEvents;
	public bool bBakeMaterialPositionOffsetIntoCollision;
	public TArray<ULandscapeLayerInfoObject> EditorCachedLayerInfos_DEPRECATED;
	public string ReimportHeightmapFilePath;
	public FGuid ReimportDestinationLayerGuid;
	public TArray<FLandscapeEditorLayerSettings> EditorLayerSettings;
	public TMap<UTexture2D,ULandscapeWeightmapUsage> WeightmapUsageMap;
	public int ComponentSizeQuads;
	public int SubsectionSizeQuads;
	public int NumSubsections;
	public bool bUsedForNavigation;
	public bool bFillCollisionUnderLandscapeForNavmesh;
	public bool bUseDynamicMaterialInstance;
	public ENavDataGatheringMode NavigationGeometryGatheringMode;
	public int MaxPaintedLayersPerComponent;
	public bool bUseLandscapeForCullingInvisibleHLODVertices;
	public bool bHasLayersContent;
	public  void ChangeLODDistanceFactor(float InLODDistanceFactor) {}
	public  void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections) {}
	public  void EditorSetLandscapeMaterial(UMaterialInterface NewLandscapeMaterial) {}
	public  void EditorApplySpline(USplineComponent InSplineComponent,float StartWidth/*=200f*/,float EndWidth/*=200f*/,float StartSideFalloff/*=200f*/,float EndSideFalloff/*=200f*/,float StartRoll/*=0f*/,float EndRoll/*=0f*/,int NumSubdivisions/*=20*/,bool bRaiseHeights/*=true*/,bool bLowerHeights/*=true*/,ULandscapeLayerInfoObject PaintLayer/*=nullptr*/,string EditLayerName/*=TEXT("")*/) {}
	public  void SetLandscapeMaterialTextureParameterValue(string ParameterName,UTexture Value) {}
	public  void SetLandscapeMaterialVectorParameterValue(string ParameterName,FLinearColor Value) {}
	public  void SetLandscapeMaterialScalarParameterValue(string ParameterName,float Value) {}
	public  ALandscape GetLandscapeActor() { return default; }
	public  bool LandscapeExportHeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget,bool InExportHeightIntoRGChannel/*=false*/,bool InExportLandscapeProxies/*=true*/) { return default; }
	public  bool LandscapeImportHeightmapFromRenderTarget(UTextureRenderTarget2D InRenderTarget,bool InImportHeightFromRGChannel/*=false*/) { return default; }
	public  bool LandscapeImportWeightmapFromRenderTarget(UTextureRenderTarget2D InRenderTarget,string InLayerName) { return default; }
	public  bool LandscapeExportWeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget,string InLayerName) { return default; }
}
