#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineMeshesUtilities.h")]
public partial class UInterchangePipelineMeshesUtilities : UObject {
// InterchangePipelineMeshesUtilities
	public static UInterchangePipelineMeshesUtilities CreateInterchangePipelineMeshesUtilities(UInterchangeBaseNodeContainer BaseNodeContainer) { return default; }
	public  void GetAllMeshInstanceUids(TArray<string> MeshInstanceUids) {}
	public  void GetAllSkinnedMeshInstance(TArray<string> MeshInstanceUids,bool bConvertStaticMeshToSkeletalMesh) {}
	public  void GetAllStaticMeshInstance(TArray<string> MeshInstanceUids,bool bConvertSkeletalMeshToStaticMesh) {}
	public  void GetAllMeshGeometry(TArray<string> MeshGeometryUids) {}
	public  void GetAllSkinnedMeshGeometry(TArray<string> MeshGeometryUids) {}
	public  void GetAllStaticMeshGeometry(TArray<string> MeshGeometryUids,bool bConvertSkeletalMeshToStaticMesh) {}
	public  void GetAllMeshGeometryNotInstanced(TArray<string> MeshGeometryUids) {}
	public  bool IsValidMeshInstanceUid(string MeshInstanceUid) { return default; }
	public  FInterchangeMeshInstance GetMeshInstanceByUid(string MeshInstanceUid) { return default; }
	public  bool IsValidMeshGeometryUid(string MeshGeometryUid) { return default; }
	public  FInterchangeMeshGeometry GetMeshGeometryByUid(string MeshGeometryUid) { return default; }
	public  void GetAllMeshInstanceUidsUsingMeshGeometryUid(string MeshGeometryUid,TArray<string> MeshInstanceUids) {}
	public  string GetMeshInstanceSkeletonRootUid(string MeshInstanceUid) { return default; }
	public  string GetMeshGeometrySkeletonRootUid(string MeshGeometryUid) { return default; }
}
