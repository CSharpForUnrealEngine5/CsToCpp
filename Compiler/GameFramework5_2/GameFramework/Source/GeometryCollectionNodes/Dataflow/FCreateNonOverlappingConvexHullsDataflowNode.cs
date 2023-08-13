namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates convex hull representation for the bones for simulation</summary>
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
public partial struct FCreateNonOverlappingConvexHullsDataflowNode {
	public FManagedArrayCollection Collection;
	public float CanRemoveFraction;
	public float SimplificationDistanceThreshold;
	public float CanExceedFraction;
	public EConvexOverlapRemovalMethodEnum OverlapRemovalMethod;
	public float OverlapRemovalShrinkPercent;
}
