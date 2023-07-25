#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
///<summary>Converts a Collection to a DynamicMesh</summary>
public partial struct FCollectionToMeshDataflowNode {
// CollectionToMeshDataflowNode
	public FManagedArrayCollection Collection;
	public bool bCenterPivot;
	public UDynamicMesh Mesh;
}
