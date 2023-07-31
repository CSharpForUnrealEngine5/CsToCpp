#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a BoundingBox into a DynamicMesh</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FBoxToMeshDataflowNode {
	public FBox Box;
	public UDynamicMesh Mesh;
	public int TriangleCount;
}
