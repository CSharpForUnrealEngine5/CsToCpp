#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMeshSampling.h")]
///<summary>Defined a named region on a mesh that will have associated triangles and bones for fast sampling at each enabled LOD.</summary>
public partial struct FSkeletalMeshSamplingRegion {
// SkeletalMeshSamplingRegion
	public string Name;
	public int LODIndex;
	public bool bSupportUniformlyDistributedSampling;
	public TArray<FSkeletalMeshSamplingRegionMaterialFilter> MaterialFilters;
	public TArray<FSkeletalMeshSamplingRegionBoneFilter> BoneFilters;
}
