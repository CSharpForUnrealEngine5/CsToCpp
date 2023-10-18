namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeGrassType.h")]
public partial struct FGrassVariety {
	public UStaticMesh GrassMesh;
	public TArray<UMaterialInterface> OverrideMaterials;
	public FPerPlatformFloat GrassDensity;
	public FPerQualityLevelFloat GrassDensityQuality;
	public bool bUseGrid;
	public float PlacementJitter;
	public FPerPlatformInt StartCullDistance;
	public FPerQualityLevelInt StartCullDistanceQuality;
	public FPerPlatformInt EndCullDistance;
	public FPerQualityLevelInt EndCullDistanceQuality;
	public int MinLOD;
	public EGrassScaling Scaling;
	public FFloatInterval ScaleX;
	public FFloatInterval ScaleY;
	public FFloatInterval ScaleZ;
	public bool RandomRotation;
	public bool AlignToSurface;
	public bool bUseLandscapeLightmap;
	public FLightingChannels LightingChannels;
	public bool bReceivesDecals;
	public bool bAffectDistanceFieldLighting;
	public bool bCastDynamicShadow;
	public bool bCastContactShadow;
	public bool bKeepInstanceBufferCPUCopy;
	public uint InstanceWorldPositionOffsetDisableDistance;
	public EShadowCacheInvalidationBehavior ShadowCacheInvalidationBehavior;
}
