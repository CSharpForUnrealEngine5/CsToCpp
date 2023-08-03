#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ADynamicMeshActor is an Actor that has a USimpleDynamicMeshComponent as it&#39;s RootObject.</summary>
[CppInclude("DynamicMeshActor.h")]
public partial class ADynamicMeshActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>DynamicMeshComponent</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
	///<summary>GetDynamicMeshComponent</summary>
	public  UDynamicMeshComponent GetDynamicMeshComponent() { return default; }
	///<summary>Control whether the DynamicMeshPool will be created when requested via GetComputeMeshPool()</summary>
	public bool bEnableComputeMeshPool;
	///<summary>The internal Mesh Pool, for use in DynamicMeshActor BPs. Use GetComputeMeshPool() to access this, as it will only be created on-demand if bEnableComputeMeshPool = true</summary>
	public UDynamicMeshPool DynamicMeshPool;
	///<summary>Access the compute mesh pool</summary>
	public  UDynamicMeshPool GetComputeMeshPool() { return default; }
	///<summary>Request a compute mesh from the Pool, which will return a previously-allocated mesh or add and return a new one. If the Pool is disabled, a new UDynamicMesh will be allocated and returned.</summary>
	public  UDynamicMesh AllocateComputeMesh() { return default; }
	///<summary>Release a compute mesh back to the Pool</summary>
	public  bool ReleaseComputeMesh(UDynamicMesh Mesh) { return default; }
	///<summary>Release all compute meshes that the Pool has allocated</summary>
	public  void ReleaseAllComputeMeshes() {}
	///<summary>Release all compute meshes that the Pool has allocated, and then release them from the Pool, so that they will be garbage-collected</summary>
	public  void FreeAllComputeMeshes() {}
}
