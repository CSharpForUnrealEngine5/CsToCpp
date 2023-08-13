namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplineControlPoint.h")]
public partial class ULandscapeSplineControlPoint : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Location in Landscape-space</summary>
	public FVector Location;
	///<summary>Rotation of tangent vector at this point (in landscape-space)</summary>
	public FRotator Rotation;
	///<summary>Half-Width of the spline at this point.</summary>
	public float Width;
	///<summary>Layer Width ratio of the spline at this point.</summary>
	public float LayerWidthRatio;
	///<summary>Falloff at the sides of the spline at this point.</summary>
	public float SideFalloff;
	///<summary>LeftSideFalloffFactor</summary>
	public float LeftSideFalloffFactor;
	///<summary>RightSideFalloffFactor</summary>
	public float RightSideFalloffFactor;
	///<summary>LeftSideLayerFalloffFactor</summary>
	public float LeftSideLayerFalloffFactor;
	///<summary>RightSideLayerFalloffFactor</summary>
	public float RightSideLayerFalloffFactor;
	///<summary>Falloff at the start/end of the spline (if this point is a start or end point, otherwise ignored).</summary>
	public float EndFalloff;
	///<summary>Vertical offset of the spline segment mesh. Useful for a river&#39;s surface, among other things.</summary>
	public float SegmentMeshOffset;
	///<summary>Name of blend layer to paint when applying spline to landscape</summary>
	public string LayerName;
	///<summary>If the spline is above the terrain, whether to raise the terrain up to the level of the spline when applying it to the landscape.</summary>
	public bool bRaiseTerrain;
	///<summary>If the spline is below the terrain, whether to lower the terrain down to the level of the spline when applying it to the landscape.</summary>
	public bool bLowerTerrain;
	///<summary>Mesh to use on the control point</summary>
	public UStaticMesh Mesh;
	///<summary>Overrides mesh&#39;s materials</summary>
	public TArray<UMaterialInterface> MaterialOverrides;
	///<summary>Scale of the control point mesh</summary>
	public FVector MeshScale;
	///<summary>bEnableCollision_DEPRECATED</summary>
	public bool bEnableCollision_DEPRECATED;
	///<summary>CollisionProfileName_DEPRECATED</summary>
	public string CollisionProfileName_DEPRECATED;
	///<summary>Whether the Control Point Mesh should cast a shadow.</summary>
	public bool bCastShadow;
	///<summary>Whether to hide the mesh in game</summary>
	public bool bHiddenInGame;
	///<summary>Whether control point mesh should be placed in landscape proxy streaming level (true) or the spline&#39;s level (false)</summary>
	public bool bPlaceSplineMeshesInStreamingLevels;
	///<summary>Max draw distance for the mesh used on this control point</summary>
	public float LDMaxDrawDistance;
	///<summary>Translucent objects with a lower sort priority draw behind objects with a higher priority.</summary>
	public int TranslucencySortPriority;
	///<summary>If true, this component will be rendered in the CustomDepth pass (usually used for outlines)</summary>
	public bool bRenderCustomDepth;
	///<summary>Mask used for stencil buffer writes.</summary>
	public ERendererStencilMask CustomDepthStencilWriteMask;
	///<summary>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)</summary>
	public int CustomDepthStencilValue;
	///<summary>Array of runtime virtual textures into which we draw the spline segment.</summary>
	public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures;
	///<summary>Lod bias for rendering to runtime virtual texture.</summary>
	public int VirtualTextureLodBias;
	///<summary>Number of lower mips in the runtime virtual texture to skip for rendering this primitive.</summary>
	public int VirtualTextureCullMips;
	///<summary>Desired cull distance in the main pass if we are rendering to both the virtual texture AND the main pass. A value of 0 has no effect.</summary>
	public float VirtualTextureMainPassMaxDrawDistance;
	///<summary>Controls if this component draws in the main pass as well as in the virtual texture.</summary>
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
	///<summary>Mesh Collision Settings</summary>
	public FBodyInstance BodyInstance;
	///<summary>bSelected</summary>
	public bool bSelected;
	///<summary>bNavDirty</summary>
	public bool bNavDirty;
	///<summary>ConnectedSegments</summary>
	public TArray<FLandscapeSplineConnection> ConnectedSegments;
	///<summary>Spline points</summary>
	public TArray<FLandscapeSplineInterpPoint> Points;
	///<summary>Bounds of points</summary>
	public FBox Bounds;
	///<summary>Control point mesh</summary>
	public UControlPointMeshComponent LocalMeshComponent;
	///<summary>World reference for if mesh component is stored in another streaming level</summary>
	public TSoftObjectPtr<UWorld> ForeignWorld;
	///<summary>Key for tracking whether this segment has been modified relative to the mesh component stored in another streaming level</summary>
	public FGuid ModificationKey;
}
