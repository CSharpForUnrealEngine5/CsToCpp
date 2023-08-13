namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings controlling how convex hulls are generated for geometry collections</summary>
[CppInclude("FractureToolConvex.h")]
public partial class UFractureConvexSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Fraction (of geometry volume) by which a cluster&#39;s convex hull volume can exceed the actual geometry volume before instead using the hulls of the children.  0 means the convex volume cannot exceed the geometry volume; 1 means the convex volume is allowed to be 100% larger (2x) the geometry volume.</summary>
	public double CanExceedFraction;
	///<summary>We simplify the convex shape to keep points spaced at least this far apart (except to keep the hull from collapsing to zero volume)</summary>
	public double SimplificationDistanceThreshold;
	///<summary>Whether to automatically cut away overlapping parts of the convex hulls, to avoid the simulation &#39;popping&#39; to fix the overlaps</summary>
	public EConvexOverlapRemoval RemoveOverlaps;
	///<summary>Overlap removal will be computed as if convex hulls were this percentage smaller (in range 0-100)</summary>
	public double OverlapRemovalShrinkPercent;
	///<summary>Fraction of the convex hulls for a cluster that we can remove before using the hulls of the children</summary>
	public double FractionAllowRemove;
	///<summary>Delete convex hulls from selected clusters.  Does not affect hulls on leaves.</summary>
	public void DeleteFromSelected() {}
	///<summary>Clear any manual adjustments to convex hulls on the selected bones</summary>
	public void ClearCustomConvex() {}
}
