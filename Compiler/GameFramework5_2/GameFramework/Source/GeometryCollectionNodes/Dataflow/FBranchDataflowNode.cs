#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Branch between two inputs based on boolean condition</summary>
public partial struct FBranchDataflowNode {
// BranchDataflowNode
	public UDynamicMesh MeshA;
	public UDynamicMesh MeshB;
	public bool bCondition;
	public UDynamicMesh Mesh;
}
