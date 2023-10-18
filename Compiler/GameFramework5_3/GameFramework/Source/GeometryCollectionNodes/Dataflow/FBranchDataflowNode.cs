namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Branch between two inputs based on boolean condition</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FBranchDataflowNode {
	public UDynamicMesh MeshA;
	public UDynamicMesh MeshB;
	public bool bCondition;
	public UDynamicMesh Mesh;
}
