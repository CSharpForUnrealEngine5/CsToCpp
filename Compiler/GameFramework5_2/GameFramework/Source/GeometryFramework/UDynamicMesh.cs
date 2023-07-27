#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UDynamicMesh.h")]
///<summary>UDynamicMesh is a UObject container for a FDynamicMesh3.</summary>
public partial class UDynamicMesh : UObject {
// DynamicMesh
	public  UDynamicMesh Reset() { return default; }
	public  UDynamicMesh ResetToCube() { return default; }
	public  bool IsEmpty() { return default; }
	public  int GetTriangleCount() { return default; }
	public FOnDynamicMeshModifiedBP MeshModifiedBPEvent;
	public UDynamicMeshGenerator MeshGenerator;
	public bool bEnableMeshGenerator;
}
