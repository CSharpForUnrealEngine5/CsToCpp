namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a DynamicMesh to a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FMeshToCollectionDataflowNode {
	public UDynamicMesh Mesh;
	public FManagedArrayCollection Collection;
}
