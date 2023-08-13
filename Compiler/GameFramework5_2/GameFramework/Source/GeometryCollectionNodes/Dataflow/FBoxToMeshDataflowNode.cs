namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a BoundingBox into a DynamicMesh</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FBoxToMeshDataflowNode {
	public FBox Box;
	public UDynamicMesh Mesh;
	public int TriangleCount;
}
