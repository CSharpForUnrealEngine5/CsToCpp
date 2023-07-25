#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
///<summary>Converts a StaticMesh into a DynamicMesh</summary>
public partial struct FStaticMeshToMeshDataflowNode {
// StaticMeshToMeshDataflowNode
	public UStaticMesh StaticMesh;
	public bool bUseHiRes;
	public int LODLevel;
	public UDynamicMesh Mesh;
}
