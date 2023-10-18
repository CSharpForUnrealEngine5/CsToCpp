namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Merge convex hulls on transforms with multiple hulls</summary>
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
public partial struct FMergeConvexHullsDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowSphereCovering SphereCovering;
	public int MaxConvexCount;
	public double ErrorTolerance;
	public FDataflowTransformSelection OptionalSelectionFilter;
	public bool bProtectNegativeSpace;
	public int TargetNumSamples;
	public double MinSampleSpacing;
	public double NegativeSpaceTolerance;
	public double MinRadius;
}
