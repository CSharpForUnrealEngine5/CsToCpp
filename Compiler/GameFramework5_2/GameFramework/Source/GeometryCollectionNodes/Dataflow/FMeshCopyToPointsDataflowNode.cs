#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
///<summary>Copies the same mesh with scale onto points</summary>
public partial struct FMeshCopyToPointsDataflowNode {
// MeshCopyToPointsDataflowNode
	public TArray<FVector> Points;
	public UDynamicMesh MeshToCopy;
	public float Scale;
	public UDynamicMesh Mesh;
}
