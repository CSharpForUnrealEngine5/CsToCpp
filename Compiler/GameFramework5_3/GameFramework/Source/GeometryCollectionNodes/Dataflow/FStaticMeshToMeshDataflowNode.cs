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
