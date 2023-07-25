#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplineControlPoint.h")]
public partial class ULandscapeSplineControlPoint : UObject {
// LandscapeSplineControlPoint
	public FVector Location;
	public FRotator Rotation;
	public float Width;
	public float LayerWidthRatio;
	public float SideFalloff;
	public float LeftSideFalloffFactor;
	public float RightSideFalloffFactor;
	public float LeftSideLayerFalloffFactor;
	public float RightSideLayerFalloffFactor;
	public float EndFalloff;
	public float SegmentMeshOffset;
	public string LayerName;
	public bool bRaiseTerrain;
	public bool bLowerTerrain;
	public UStaticMesh Mesh;
	public TArray<UMaterialInterface> MaterialOverrides;
	public FVector MeshScale;
	public bool bEnableCollision_DEPRECATED;
	public string CollisionProfileName_DEPRECATED;
	public bool bCastShadow;
	public bool bHiddenInGame;
	public bool bPlaceSplineMeshesInStreamingLevels;
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
	public TArray<FLandscapeSplineConnection> ConnectedSegments;
	public TArray<FLandscapeSplineInterpPoint> Points;
	public FBox Bounds;
	public UControlPointMeshComponent LocalMeshComponent;
	public TSoftObjectPtr<UWorld> ForeignWorld;
	public FGuid ModificationKey;
}
