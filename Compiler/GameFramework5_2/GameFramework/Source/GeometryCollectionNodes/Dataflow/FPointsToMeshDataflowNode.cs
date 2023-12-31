namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts points into a DynamicMesh</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FPointsToMeshDataflowNode {
	public TArray<FVector> Points;
	public UDynamicMesh Mesh;
	public int TriangleCount;
}
