namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct containing all parameters used to perform a Skeletal Mesh merge.</summary>
[CppInclude("SkeletalMergingLibrary.h")]
public partial struct FSkeletalMeshMergeParams {
	public TArray<FSkelMeshMergeSectionMapping> MeshSectionMappings;
	public TArray<FSkelMeshMergeMeshUVTransforms> UVTransformsPerMesh;
	public TArray<USkeletalMesh> MeshesToMerge;
	public int StripTopLODS;
	public bool bNeedsCpuAccess;
	public bool bSkeletonBefore;
	public USkeleton Skeleton;
}
