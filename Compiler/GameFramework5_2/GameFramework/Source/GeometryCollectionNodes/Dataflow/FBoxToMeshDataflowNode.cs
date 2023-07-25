#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
///<summary>Converts a BoundingBox into a DynamicMesh</summary>
public partial struct FBoxToMeshDataflowNode {
// BoxToMeshDataflowNode
	public FBox Box;
	public UDynamicMesh Mesh;
	public int TriangleCount;
}
