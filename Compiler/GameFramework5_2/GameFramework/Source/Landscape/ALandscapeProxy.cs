namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeProxy.h")]
public partial class ALandscapeProxy : APartitionActor {
	public static UClass StaticClass() {return default;}
	///<summary>SplineComponent</summary>
	public ULandscapeSplinesComponent SplineComponent;
	///<summary>Guid for LandscapeEditorInfo *</summary>
	public FGuid LandscapeGuid;
	///<summary>PerLODOverrideMaterials</summary>
	public TArray<FLandscapePerLODMaterialOverride> PerLODOverrideMaterials;
	///<summary>PreEditPerLODOverrideMaterials</summary>
	public TArray<FLandscapePerLODMaterialOverride> PreEditPerLODOverrideMaterials;
	///<summary>Offset in quads from global components grid origin (in quads) *</summary>
	public FIntPoint LandscapeSectionOffset;
	///<summary>Max LOD level to use when rendering, -1 means the max available</summary>
	public int MaxLODLevel;
	///<summary>LODDistanceFactor_DEPRECATED</summary>
	public float LODDistanceFactor_DEPRECATED;
	///<summary>LODFalloff_DEPRECATED</summary>
	public ELandscapeLODFalloff LODFalloff_DEPRECATED;
	///<summary>Component screen size (0.0 - 1.0) at which we should keep sub sections. This is mostly pertinent if you have large component of &gt; 64 and component are close to the camera. The goal is to reduce draw call, so if a component is smaller than the value, we merge all subsections into 1 drawcall.</summary>
	public float ComponentScreenSizeToUseSubSections;
	///<summary>This is the starting screen size used to calculate the distribution. You can increase the value if you want less LOD0 component, and you use very large landscape component.</summary>
	public float LOD0ScreenSize;
	///<summary>The distribution setting used to change the LOD 0 generation, 1.75 is the normal distribution, numbers influence directly the LOD0 proportion on screen.</summary>
	public float LOD0DistributionSetting;
	///<summary>The distribution setting used to change the LOD generation, 2 is the normal distribution, small number mean you want your last LODs to take more screen space and big number mean you want your first LODs to take more screen space.</summary>
	public float LODDistributionSetting;
	///<summary>LOD level to use when exporting the landscape to obj or FBX</summary>
	public int ExportLOD;
	///<summary>Display Order of the targets</summary>
	public TArray<FName> TargetDisplayOrderList;
	///<summary>Display Order mode for the targets</summary>
	public ELandscapeLayerDisplayMode TargetDisplayOrder;
	///<summary>LOD level to use when running lightmass (increase to 1 or 2 for large landscapes to stop lightmass crashing)</summary>
	public int StaticLightingLOD;
	///<summary>Default physical material, used when no per-layer values physical materials</summary>
	public UPhysicalMaterial DefaultPhysMaterial;
	///<summary>Allows artists to adjust the distance where textures using UV 0 are streamed in/out.</summary>
	public float StreamingDistanceMultiplier;
	///<summary>Combined material used to render the landscape</summary>
	public UMaterialInterface LandscapeMaterial;
	///<summary>Material used to render landscape components with holes. If not set, LandscapeMaterial will be used (blend mode will be overridden to Masked if it is set to Opaque)</summary>
	public UMaterialInterface LandscapeHoleMaterial;
	///<summary>LandscapeMaterialsOverride_DEPRECATED</summary>
	public TArray<FLandscapeProxyMaterialOverride> LandscapeMaterialsOverride_DEPRECATED;
	///<summary>PreEditLandscapeMaterial</summary>
	public UMaterialInterface PreEditLandscapeMaterial;
	///<summary>PreEditLandscapeHoleMaterial</summary>
	public UMaterialInterface PreEditLandscapeHoleMaterial;
	///<summary>bIsPerformingInteractiveActionOnLandscapeMaterialOverride</summary>
	public bool bIsPerformingInteractiveActionOnLandscapeMaterialOverride;
	///<summary>Array of runtime virtual textures into which we draw this landscape.</summary>
	public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures;
	///<summary>Placeholder for details customization button.</summary>
	public bool bSetCreateRuntimeVirtualTextureVolumes;
	///<summary>Use a single quad to render this landscape to runtime virtual texture pages.</summary>
	public bool bVirtualTextureRenderWithQuad;
	///<summary>Use highest quality heightmap interpolation when using a single quad to render this landscape to runtime virtual texture pages.</summary>
	public bool bVirtualTextureRenderWithQuadHQ;
	///<summary>Number of mesh levels to use when rendering landscape into runtime virtual texture.</summary>
	public int VirtualTextureNumLods;
	///<summary>Bias to the LOD selected for rendering to runtime virtual textures.</summary>
	public int VirtualTextureLodBias;
	///<summary>Controls if this component draws in the main pass as well as in the virtual texture.</summary>
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
	///<summary>SetVirtualTextureRenderPassType</summary>
	public void SetVirtualTextureRenderPassType(ERuntimeVirtualTextureMainPassType InType) {}
	///<summary>Allows overriding the landscape bounds. This is useful if you distort the landscape with world-position-offset, for example</summary>
	public float NegativeZBoundsExtension;
	///<summary>Allows overriding the landscape bounds. This is useful if you distort the landscape with world-position-offset, for example</summary>
	public float PositiveZBoundsExtension;
	///<summary>The array of LandscapeComponent that are used by the landscape</summary>
	public TArray<ULandscapeComponent> LandscapeComponents;
	///<summary>Array of LandscapeHeightfieldCollisionComponent</summary>
	public TArray<ULandscapeHeightfieldCollisionComponent> CollisionComponents;
	///<summary>FoliageComponents</summary>
	public TArray<UHierarchicalInstancedStaticMeshComponent> FoliageComponents;
	///<summary>NaniteComponent</summary>
	public ULandscapeNaniteComponent NaniteComponent;
	///<summary>Only used outside of the editor (e.g. in cooked builds)</summary>
	public bool bHasLandscapeGrass;
	///<summary>The resolution to cache lighting at, in texels/quad in one axis</summary>
	public float StaticLightingResolution;
	///<summary>Controls whether the primitive component should cast a shadow or not.</summary>
	public bool CastShadow;
	///<summary>Controls whether the primitive should cast shadows in the case of non precomputed shadowing.  This flag is only used if CastShadow is true. *</summary>
	public bool bCastDynamicShadow;
	///<summary>Whether the object should cast a static shadow from shadow casting lights.  This flag is only used if CastShadow is true.</summary>
	public bool bCastStaticShadow;
	///<summary>Whether the object should cast contact shadows. This flag is only used if CastShadow is true.</summary>
	public bool bCastContactShadow;
	///<summary>When enabled, the component will be rendering into the far shadow cascades(only for directional lights).  This flag is only used if CastShadow is true.</summary>
	public bool bCastFarShadow;
	///<summary>If true, the primitive will cast shadows even if bHidden is true.  Controls whether the primitive should cast shadows when hidden.  This flag is only used if CastShadow is true.</summary>
	public bool bCastHiddenShadow;
	///<summary>Whether this primitive should cast dynamic shadows as if it were a two sided material.  This flag is only used if CastShadow is true.</summary>
	public bool bCastShadowAsTwoSided;
	///<summary>Controls whether the primitive should affect dynamic distance field lighting methods.  This flag is only used if CastShadow is true. *</summary>
	public bool bAffectDistanceFieldLighting;
	///<summary>Channels that this Landscape should be in.  Lights with matching channels will affect the Landscape.</summary>
	public FLightingChannels LightingChannels;
	///<summary>Whether to use the landscape material&#39;s vertical world position offset when calculating static lighting.</summary>
	public bool bUseMaterialPositionOffsetInStaticLighting;
	///<summary>If true, the Landscape will be rendered in the CustomDepth pass (usually used for outlines)</summary>
	public bool bRenderCustomDepth;
	///<summary>Mask used for stencil buffer writes.</summary>
	public ERendererStencilMask CustomDepthStencilWriteMask;
	///<summary>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)</summary>
	public int CustomDepthStencilValue;
	///<summary>Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object.</summary>
	public float LDMaxDrawDistance;
	///<summary>The Lightmass settings for this object.</summary>
	public FLightmassPrimitiveSettings LightmassSettings;
	///<summary>Landscape LOD to use for collision tests. Higher numbers use less memory and process faster, but are much less accurate</summary>
	public int CollisionMipLevel;
	///<summary>If set higher than the &quot;Collision Mip Level&quot;, this specifies the Landscape LOD to use for &quot;simple collision&quot; tests, otherwise the &quot;Collision Mip Level&quot; is used for both simple and complex collision.</summary>
	public int SimpleCollisionMipLevel;
	///<summary>Collision profile settings for this landscape</summary>
	public FBodyInstance BodyInstance;
	///<summary>If true, Landscape will generate overlap events when other components are overlapping it (eg Begin Overlap).</summary>
	public bool bGenerateOverlapEvents;
	///<summary>Whether to bake the landscape material&#39;s vertical world position offset into the collision heightfield.</summary>
	public bool bBakeMaterialPositionOffsetIntoCollision;
	///<summary>EditorCachedLayerInfos_DEPRECATED</summary>
	public TArray<ULandscapeLayerInfoObject> EditorCachedLayerInfos_DEPRECATED;
	///<summary>ReimportHeightmapFilePath</summary>
	public string ReimportHeightmapFilePath;
	///<summary>Height and weightmap import destination layer guid</summary>
	public FGuid ReimportDestinationLayerGuid;
	///<summary>EditorLayerSettings</summary>
	public TArray<FLandscapeEditorLayerSettings> EditorLayerSettings;
	///<summary>Map of weightmap usage</summary>
	public TMap<UTexture2D,ULandscapeWeightmapUsage> WeightmapUsageMap;
	///<summary>Data set at creation time</summary>
	public int ComponentSizeQuads;
	///<summary>Total number of quads in each component</summary>
	public int SubsectionSizeQuads;
	///<summary>Number of quads for a subsection of a component. SubsectionSizeQuads+1 must be a power of two.</summary>
	public int NumSubsections;
	///<summary>Hints navigation system whether this landscape will ever be navigated on. true by default, but make sure to set it to false for faraway, background landscapes</summary>
	public bool bUsedForNavigation;
	///<summary>Set to true to prevent navmesh generation under the terrain geometry</summary>
	public bool bFillCollisionUnderLandscapeForNavmesh;
	///<summary>When set to true it will generate MaterialInstanceDynamic for each components, so material can be changed at runtime</summary>
	public bool bUseDynamicMaterialInstance;
	///<summary>NavigationGeometryGatheringMode</summary>
	public ENavDataGatheringMode NavigationGeometryGatheringMode;
	///<summary>MaxPaintedLayersPerComponent</summary>
	public int MaxPaintedLayersPerComponent;
	///<summary>Flag whether or not this Landscape&#39;s surface can be used for culling hidden triangles *</summary>
	public bool bUseLandscapeForCullingInvisibleHLODVertices;
	///<summary>Flag that tell if we have some layers content *</summary>
	public bool bHasLayersContent;
	///<summary>Change the Level of Detail distance factor</summary>
	public virtual void ChangeLODDistanceFactor(float InLODDistanceFactor) {}
	///<summary>Change ComponentScreenSizeToUseSubSections value on the render proxy.</summary>
	public virtual void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections) {}
	///<summary>Setter for LandscapeMaterial. Has no effect outside the editor.</summary>
	public void EditorSetLandscapeMaterial(UMaterialInterface NewLandscapeMaterial) {}
	///<summary>Deform landscape using a given spline</summary>
	public void EditorApplySpline(USplineComponent InSplineComponent,float StartWidth/*=200f*/,float EndWidth/*=200f*/,float StartSideFalloff/*=200f*/,float EndSideFalloff/*=200f*/,float StartRoll/*=0f*/,float EndRoll/*=0f*/,int NumSubdivisions/*=20*/,bool bRaiseHeights/*=true*/,bool bLowerHeights/*=true*/,ULandscapeLayerInfoObject PaintLayer/*=nullptr*/,FName EditLayerName/*=TEXT("")*/) {}
	///<summary>Set an MID texture parameter value for all landscape components.</summary>
	public void SetLandscapeMaterialTextureParameterValue(FName ParameterName,UTexture Value) {}
	///<summary>Set an MID vector parameter value for all landscape components.</summary>
	public void SetLandscapeMaterialVectorParameterValue(FName ParameterName,FLinearColor Value) {}
	///<summary>Set a MID scalar (float) parameter value for all landscape components.</summary>
	public void SetLandscapeMaterialScalarParameterValue(FName ParameterName,float Value) {}
	///<summary>GetLandscapeActor</summary>
	public virtual ALandscape GetLandscapeActor() { return default; }
	///<summary>Output a landscape heightmap to a render target</summary>
	public bool LandscapeExportHeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget,bool InExportHeightIntoRGChannel/*=false*/,bool InExportLandscapeProxies/*=true*/) { return default; }
	///<summary>Overwrites a landscape heightmap with render target data</summary>
	public bool LandscapeImportHeightmapFromRenderTarget(UTextureRenderTarget2D InRenderTarget,bool InImportHeightFromRGChannel/*=false*/) { return default; }
	///<summary>Overwrites a landscape weightmap with render target data</summary>
	public bool LandscapeImportWeightmapFromRenderTarget(UTextureRenderTarget2D InRenderTarget,FName InLayerName) { return default; }
	///<summary>Output a landscape weightmap to a render target</summary>
	public bool LandscapeExportWeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget,FName InLayerName) { return default; }
}
