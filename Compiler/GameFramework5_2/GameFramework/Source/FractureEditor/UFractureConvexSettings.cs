#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolConvex.h")]
///<summary>Settings controlling how convex hulls are generated for geometry collections</summary>
public partial class UFractureConvexSettings : UFractureToolSettings {
// FractureConvexSettings
	public double CanExceedFraction;
	public double SimplificationDistanceThreshold;
	public EConvexOverlapRemoval RemoveOverlaps;
	public double OverlapRemovalShrinkPercent;
	public double FractionAllowRemove;
	public  void DeleteFromSelected() {}
	public  void ClearCustomConvex() {}
}
