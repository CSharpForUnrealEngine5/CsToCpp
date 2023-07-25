#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UDynamicMesh.h")]
///<summary>UDynamicMeshPool manages a Pool of UDynamicMesh objects. This allows</summary>
public partial class UDynamicMeshPool : UObject {
// DynamicMeshPool
	public UObject RequestMesh() { return default; }
	public void ReturnMesh(UObject Mesh) {}
	public void ReturnAllMeshes() {}
	public void FreeAllMeshes() {}
	public TArray<UDynamicMesh> CachedMeshes;
	public TArray<UDynamicMesh> AllCreatedMeshes;
}
