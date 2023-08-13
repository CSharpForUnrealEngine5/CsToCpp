namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that holds the relevant properties that can help decide if instances of different</summary>
[CppInclude("ISMPartition/ISMComponentDescriptor.h")]
public partial struct FISMComponentDescriptorBase {
	public uint Hash;
	public UClass ComponentClass;
	public EComponentMobility Mobility;
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
	public ELightmapType LightmapType;
	public FLightingChannels LightingChannels;
	public int RayTracingGroupId;
	public ERayTracingGroupCullingPriority RayTracingGroupCullingPriority;
	public EHasCustomNavigableGeometry bHasCustomNavigableGeometry;
	public ERendererStencilMask CustomDepthStencilWriteMask;
	public FBodyInstance BodyInstance;
	public int InstanceStartCullDistance;
	public int InstanceEndCullDistance;
	public int VirtualTextureCullMips;
	public int TranslucencySortPriority;
	public int OverriddenLightMapRes;
	public int CustomDepthStencilValue;
	public EHLODBatchingPolicy HLODBatchingPolicy;
	public bool bCastShadow;
	public bool bCastDynamicShadow;
	public bool bCastStaticShadow;
	public bool bCastContactShadow;
	public bool bCastShadowAsTwoSided;
	public bool bAffectDynamicIndirectLighting;
	public bool bAffectDistanceFieldLighting;
	public bool bReceivesDecals;
	public bool bOverrideLightMapRes;
	public bool bUseAsOccluder;
	public bool bEnableDensityScaling;
	public bool bEnableDiscardOnLoad;
	public bool bRenderCustomDepth;
	public bool bVisibleInRayTracing;
	public bool bHiddenInGame;
	public bool bIsEditorOnly;
	public bool bVisible;
	public bool bEvaluateWorldPositionOffset;
	public bool bReverseCulling;
	public bool bIncludeInHLOD;
	public bool bConsiderForActorPlacementWhenHidden;
	public bool bUseDefaultCollision;
	public bool bGenerateOverlapEvents;
	public int WorldPositionOffsetDisableDistance;
}
