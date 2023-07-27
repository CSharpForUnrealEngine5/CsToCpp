#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DynamicMeshActor.h")]
///<summary>ADynamicMeshActor is an Actor that has a USimpleDynamicMeshComponent as it's RootObject.</summary>
public partial class ADynamicMeshActor : AActor {
// DynamicMeshActor
	public UDynamicMeshComponent DynamicMeshComponent;
	public  UDynamicMeshComponent GetDynamicMeshComponent() { return default; }
	public bool bEnableComputeMeshPool;
	public UDynamicMeshPool DynamicMeshPool;
	public  UDynamicMeshPool GetComputeMeshPool() { return default; }
	public  UDynamicMesh AllocateComputeMesh() { return default; }
	public  bool ReleaseComputeMesh(UDynamicMesh Mesh) { return default; }
	public  void ReleaseAllComputeMeshes() {}
	public  void FreeAllComputeMeshes() {}
}
