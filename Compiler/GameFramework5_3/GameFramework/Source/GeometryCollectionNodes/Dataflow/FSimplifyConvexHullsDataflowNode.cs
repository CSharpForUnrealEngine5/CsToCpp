namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
public partial struct FSimplifyConvexHullsDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection OptionalSelectionFilter;
	public EConvexHullSimplifyMethod SimplifyMethod;
	public float SimplificationAngleThreshold;
	public float SimplificationDistanceThreshold;
	public int MinTargetTriangleCount;
	public bool bUseExistingVertices;
}
