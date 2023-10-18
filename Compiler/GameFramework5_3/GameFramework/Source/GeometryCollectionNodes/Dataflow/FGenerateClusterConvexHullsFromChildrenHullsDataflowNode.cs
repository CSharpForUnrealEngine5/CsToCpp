namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates cluster convex hulls for children hulls</summary>
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
public partial struct FGenerateClusterConvexHullsFromChildrenHullsDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowSphereCovering SphereCovering;
	public int ConvexCount;
	public double ErrorTolerance;
	public bool bPreferExternalCollisionShapes;
	public FDataflowTransformSelection OptionalSelectionFilter;
	public bool bProtectNegativeSpace;
	public int TargetNumSamples;
	public double MinSampleSpacing;
	public double NegativeSpaceTolerance;
	public double MinRadius;
}
