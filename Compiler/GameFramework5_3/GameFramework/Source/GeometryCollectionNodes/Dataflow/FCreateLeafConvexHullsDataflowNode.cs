namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
public partial struct FCreateLeafConvexHullsDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection OptionalSelectionFilter;
	public EGenerateConvexMethod GenerateMethod;
	public float IntersectIfComputedIsSmallerByFactor;
	public float MinExternalVolumeToIntersect;
	public float SimplificationDistanceThreshold;
	public FDataflowConvexDecompositionSettings ConvexDecompositionSettings;
}
