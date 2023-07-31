#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Copies the same mesh with scale onto points</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FMeshCopyToPointsDataflowNode {
	public TArray<FVector> Points;
	public UDynamicMesh MeshToCopy;
	public float Scale;
	public UDynamicMesh Mesh;
}
