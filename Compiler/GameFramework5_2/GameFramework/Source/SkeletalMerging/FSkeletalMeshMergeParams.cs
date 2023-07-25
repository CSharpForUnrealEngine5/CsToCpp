#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMergingLibrary.h")]
///<summary>Struct containing all parameters used to perform a Skeletal Mesh merge.</summary>
public partial struct FSkeletalMeshMergeParams {
// SkeletalMeshMergeParams
	public TArray<FSkelMeshMergeSectionMapping> MeshSectionMappings;
	public TArray<FSkelMeshMergeMeshUVTransforms> UVTransformsPerMesh;
	public TArray<USkeletalMesh> MeshesToMerge;
	public int StripTopLODS;
	public bool bNeedsCpuAccess;
	public bool bSkeletonBefore;
	public USkeleton Skeleton;
}
