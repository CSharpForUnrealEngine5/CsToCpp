namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Convert convex hulls on a geometry collection to a dynamic mesh</summary>
[CppInclude("Dataflow/GeometryCollectionDebugNodes.h")]
public partial struct FConvexHullToMeshDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection OptionalSelectionFilter;
	public UDynamicMesh Mesh;
}
