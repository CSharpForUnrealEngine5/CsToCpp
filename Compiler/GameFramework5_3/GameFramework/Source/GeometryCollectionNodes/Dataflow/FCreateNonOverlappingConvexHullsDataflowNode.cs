namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates convex hull representation for the bones for simulation</summary>
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
public partial struct FCreateNonOverlappingConvexHullsDataflowNode {
	public FManagedArrayCollection Collection;
	public float CanExceedFraction;
	public float SimplificationDistanceThreshold;
	public EConvexOverlapRemovalMethodEnum OverlapRemovalMethod;
	public float OverlapRemovalShrinkPercent;
	public float CanRemoveFraction;
}
