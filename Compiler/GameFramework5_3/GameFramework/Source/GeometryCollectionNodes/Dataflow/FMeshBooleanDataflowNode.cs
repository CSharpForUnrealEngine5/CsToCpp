namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh boolean (Union, Intersect, Difference) between two meshes</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FMeshBooleanDataflowNode {
	public EMeshBooleanOperationEnum Operation;
	public UDynamicMesh Mesh1;
	public UDynamicMesh Mesh2;
	public UDynamicMesh Mesh;
}
