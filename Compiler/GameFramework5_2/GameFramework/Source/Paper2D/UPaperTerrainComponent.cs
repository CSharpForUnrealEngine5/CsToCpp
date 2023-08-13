namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The terrain visualization component for an associated spline component.</summary>
[CppInclude("PaperTerrainComponent.h")]
public partial class UPaperTerrainComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The terrain material to apply to this component (set of rules for which sprites are used on different surfaces or the interior)</summary>
	public UPaperTerrainMaterial TerrainMaterial;
	///<summary>bClosedSpline</summary>
	public bool bClosedSpline;
	///<summary>bFilledSpline</summary>
	public bool bFilledSpline;
	///<summary>AssociatedSpline</summary>
	public UPaperTerrainSplineComponent AssociatedSpline;
	///<summary>Random seed used for choosing which spline meshes to use.</summary>
	public int RandomSeed;
	///<summary>The overlap amount between segments</summary>
	public float SegmentOverlapAmount;
	///<summary>The color of the terrain (passed to the sprite material as a vertex color)</summary>
	public FLinearColor TerrainColor;
	///<summary>Number of steps per spline segment to place in the reparameterization table</summary>
	public int ReparamStepsPerSegment;
	///<summary>Collision domain (no collision, 2D (experimental), or 3D)</summary>
	public ESpriteCollisionMode SpriteCollisionDomain;
	///<summary>The extrusion thickness of collision geometry when using a 3D collision domain</summary>
	public float CollisionThickness;
	///<summary>Set color of the terrain</summary>
	public void SetTerrainColor(FLinearColor NewColor) {}
	///<summary>Description of collision</summary>
	public UBodySetup CachedBodySetup;
}
