#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a StaticMesh into a DynamicMesh</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FStaticMeshToMeshDataflowNode {
	public UStaticMesh StaticMesh;
	public bool bUseHiRes;
	public int LODLevel;
	public UDynamicMesh Mesh;
}
