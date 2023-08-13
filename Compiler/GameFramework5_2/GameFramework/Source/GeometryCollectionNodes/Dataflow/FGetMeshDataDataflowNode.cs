namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Outputs Mesh data</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FGetMeshDataDataflowNode {
	public UDynamicMesh Mesh;
	public int VertexCount;
	public int EdgeCount;
	public int TriangleCount;
}
