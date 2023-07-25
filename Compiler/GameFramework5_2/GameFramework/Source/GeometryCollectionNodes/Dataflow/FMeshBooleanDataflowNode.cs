#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
///<summary>Mesh boolean (Union, Intersect, Difference) between two meshes</summary>
public partial struct FMeshBooleanDataflowNode {
// MeshBooleanDataflowNode
	public EMeshBooleanOperationEnum Operation;
	public UDynamicMesh Mesh1;
	public UDynamicMesh Mesh2;
	public UDynamicMesh Mesh;
}
