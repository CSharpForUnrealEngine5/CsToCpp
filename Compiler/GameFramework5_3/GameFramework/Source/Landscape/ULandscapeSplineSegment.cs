namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplineSegment.h")]
public partial class ULandscapeSplineSegment : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Directly editable data:</summary>
	public FLandscapeSplineSegmentConnection Connections;
	///<summary>Name of blend layer to paint when applying spline to landscape</summary>
	public FName LayerName;
	///<summary>If the spline is above the terrain, whether to raise the terrain up to the level of the spline when applying it to the landscape.</summary>
	public bool bRaiseTerrain;
	///<summary>If the spline is below the terrain, whether to lower the terrain down to the level of the spline when applying it to the landscape.</summary>
	public bool bLowerTerrain;
	///<summary>Spline meshes from this list are used in random order along the spline.</summary>
	public TArray<FLandscapeSplineMeshEntry> SplineMeshes;
	///<summary>bEnableCollision_DEPRECATED</summary>
	public bool bEnableCollision_DEPRECATED;
	///<summary>CollisionProfileName_DEPRECATED</summary>
	public FName CollisionProfileName_DEPRECATED;
	///<summary>Whether the Spline Meshes should cast a shadow.</summary>
	public bool bCastShadow;
	///<summary>Whether to hide the mesh in game</summary>
	public bool bHiddenInGame;
	///<summary>Whether spline meshes should be placed in landscape proxy streaming levels (true) or the spline&#39;s level (false)</summary>
	public bool bPlaceSplineMeshesInStreamingLevels;
	///<summary>Random seed used for choosing which order to use spline meshes. Ignored if only one mesh is set.</summary>
	public int RandomSeed;
	///<summary>Max draw distance for all the mesh pieces used in this spline</summary>
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
	///<summary>Actual data for spline.</summary>
	public FInterpCurveVector SplineInfo;
	///<summary>Spline points</summary>
	public TArray<FLandscapeSplineInterpPoint> Points;
	///<summary>Bounds of points</summary>
	public FBox Bounds;
	///<summary>Spline meshes</summary>
	public TArray<USplineMeshComponent> LocalMeshComponents;
	///<summary>World references for mesh components stored in other streaming levels</summary>
	public TArray<TSoftObjectPtr<UWorld>> ForeignWorlds;
	///<summary>Key for tracking whether this segment has been modified relative to the mesh components stored in other streaming levels</summary>
	public FGuid ModificationKey;
}
