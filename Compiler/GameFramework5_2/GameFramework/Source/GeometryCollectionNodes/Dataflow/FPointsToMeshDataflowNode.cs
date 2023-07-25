#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
///<summary>Converts points into a DynamicMesh</summary>
public partial struct FPointsToMeshDataflowNode {
// PointsToMeshDataflowNode
	public TArray<FVector> Points;
	public UDynamicMesh Mesh;
	public int TriangleCount;
}
