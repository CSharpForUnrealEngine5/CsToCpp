#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDynamicMeshPool manages a Pool of UDynamicMesh objects. This allows</summary>
[CppInclude("UDynamicMesh.h")]
public partial class UDynamicMeshPool : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>@return an available UDynamicMesh from the pool (possibly allocating a new mesh)</summary>
	public  UDynamicMesh RequestMesh() { return default; }
	///<summary>Release a UDynamicMesh returned by RequestMesh() back to the pool</summary>
	public  void ReturnMesh(UDynamicMesh Mesh) {}
	///<summary>Release all GeneratedMeshes back to the pool</summary>
	public  void ReturnAllMeshes() {}
	///<summary>Release all GeneratedMeshes back to the pool and allow them to be garbage collected</summary>
	public  void FreeAllMeshes() {}
	///<summary>Meshes in the pool that are available</summary>
	public TArray<UDynamicMesh> CachedMeshes;
	///<summary>All meshes the pool has allocated</summary>
	public TArray<UDynamicMesh> AllCreatedMeshes;
}
