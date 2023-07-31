#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a DynamicMesh to a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FMeshToCollectionDataflowNode {
	public UDynamicMesh Mesh;
	public FManagedArrayCollection Collection;
}
