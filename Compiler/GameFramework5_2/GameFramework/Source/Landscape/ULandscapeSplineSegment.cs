#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplineSegment.h")]
public partial class ULandscapeSplineSegment : UObject {
// LandscapeSplineSegment
	public FLandscapeSplineSegmentConnection Connections;
	public string LayerName;
	public bool bRaiseTerrain;
	public bool bLowerTerrain;
	public TArray<FLandscapeSplineMeshEntry> SplineMeshes;
	public bool bEnableCollision_DEPRECATED;
	public string CollisionProfileName_DEPRECATED;
	public bool bCastShadow;
	public bool bHiddenInGame;
	public bool bPlaceSplineMeshesInStreamingLevels;
	public int RandomSeed;
	public float LDMaxDrawDistance;
	public int TranslucencySortPriority;
	public bool bRenderCustomDepth;
	public ERendererStencilMask CustomDepthStencilWriteMask;
	public int CustomDepthStencilValue;
	public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures;
	public int VirtualTextureLodBias;
	public int VirtualTextureCullMips;
	public float VirtualTextureMainPassMaxDrawDistance;
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
	public FBodyInstance BodyInstance;
	public bool bSelected;
	public bool bNavDirty;
	public FInterpCurveVector SplineInfo;
	public TArray<FLandscapeSplineInterpPoint> Points;
	public FBox Bounds;
	public TArray<USplineMeshComponent> LocalMeshComponents;
	public TArray<TSoftObjectPtr<UWorld>> ForeignWorlds;
	public FGuid ModificationKey;
}
