#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineMeshesUtilities.h")]
public partial class UInterchangePipelineMeshesUtilities : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Create an instance of UInterchangePipelineMeshesUtilities.</summary>
	public static UInterchangePipelineMeshesUtilities CreateInterchangePipelineMeshesUtilities(UInterchangeBaseNodeContainer BaseNodeContainer) { return default; }
	///<summary>Get all mesh instance unique ids.</summary>
	public  void GetAllMeshInstanceUids(TArray<string> MeshInstanceUids) {}
	///<summary>Get all skinned mesh instance unique ids.</summary>
	public  void GetAllSkinnedMeshInstance(TArray<string> MeshInstanceUids,bool bConvertStaticMeshToSkeletalMesh) {}
	///<summary>Get all static mesh instance unique ids.</summary>
	public  void GetAllStaticMeshInstance(TArray<string> MeshInstanceUids,bool bConvertSkeletalMeshToStaticMesh) {}
	///<summary>Get all mesh geometry unique ids.</summary>
	public  void GetAllMeshGeometry(TArray<string> MeshGeometryUids) {}
	///<summary>Get all skinned mesh geometry unique ids.</summary>
	public  void GetAllSkinnedMeshGeometry(TArray<string> MeshGeometryUids) {}
	///<summary>Get all static mesh geometry unique ids.</summary>
	public  void GetAllStaticMeshGeometry(TArray<string> MeshGeometryUids,bool bConvertSkeletalMeshToStaticMesh) {}
	///<summary>Get all not instanced mesh geometry unique ids.</summary>
	public  void GetAllMeshGeometryNotInstanced(TArray<string> MeshGeometryUids) {}
	///<summary>Return true if there is an existing FInterchangeMeshInstance matching the MeshInstanceUid key.</summary>
	public  bool IsValidMeshInstanceUid(string MeshInstanceUid) { return default; }
	///<summary>Get the instanced mesh from the unique ids.</summary>
	public  FInterchangeMeshInstance GetMeshInstanceByUid(string MeshInstanceUid) { return default; }
	///<summary>Return true if there is an existing FInterchangeMeshGeometry matching the MeshInstanceUid key.</summary>
	public  bool IsValidMeshGeometryUid(string MeshGeometryUid) { return default; }
	///<summary>Get the geometry mesh from the unique ids.</summary>
	public  FInterchangeMeshGeometry GetMeshGeometryByUid(string MeshGeometryUid) { return default; }
	///<summary>Get all instanced mesh uids using the mesh geometry unique ids.</summary>
	public  void GetAllMeshInstanceUidsUsingMeshGeometryUid(string MeshGeometryUid,TArray<string> MeshInstanceUids) {}
	///<summary>Return the skeleton root node Uid, this is the uid for a UInterchangeSceneNode that has a &quot;Joint&quot; specialized type.</summary>
	public  string GetMeshInstanceSkeletonRootUid(string MeshInstanceUid) { return default; }
	///<summary>Return the skeleton root node Uid, this is the uid for a UInterchangeSceneNode that has a &quot;Joint&quot; specialized type.</summary>
	public  string GetMeshGeometrySkeletonRootUid(string MeshGeometryUid) { return default; }
}
