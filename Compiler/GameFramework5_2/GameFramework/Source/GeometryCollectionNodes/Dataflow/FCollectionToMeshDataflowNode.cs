namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a Collection to a DynamicMesh</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FCollectionToMeshDataflowNode {
	public FManagedArrayCollection Collection;
	public bool bCenterPivot;
	public UDynamicMesh Mesh;
}
