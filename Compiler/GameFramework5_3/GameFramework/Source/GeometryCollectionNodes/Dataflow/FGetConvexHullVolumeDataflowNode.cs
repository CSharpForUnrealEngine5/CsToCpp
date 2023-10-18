namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get the sum of volumes of the convex hulls on the selected nodes</summary>
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
public partial struct FGetConvexHullVolumeDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public float Volume;
	public bool bSumChildrenForClustersWithoutHulls;
	public bool bVolumeOfUnion;
}
