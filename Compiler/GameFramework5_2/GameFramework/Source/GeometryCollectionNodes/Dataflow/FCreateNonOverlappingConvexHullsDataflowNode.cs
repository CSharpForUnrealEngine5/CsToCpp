#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
///<summary>Generates convex hull representation for the bones for simulation</summary>
public partial struct FCreateNonOverlappingConvexHullsDataflowNode {
// CreateNonOverlappingConvexHullsDataflowNode
	public FManagedArrayCollection Collection;
	public float CanRemoveFraction;
	public float SimplificationDistanceThreshold;
	public float CanExceedFraction;
	public EConvexOverlapRemovalMethodEnum OverlapRemovalMethod;
	public float OverlapRemovalShrinkPercent;
}
