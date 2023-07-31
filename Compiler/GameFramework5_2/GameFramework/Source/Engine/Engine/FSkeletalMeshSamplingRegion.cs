#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defined a named region on a mesh that will have associated triangles and bones for fast sampling at each enabled LOD.</summary>
[CppInclude("Engine/SkeletalMeshSampling.h")]
public partial struct FSkeletalMeshSamplingRegion {
	public string Name;
	public int LODIndex;
	public bool bSupportUniformlyDistributedSampling;
	public TArray<FSkeletalMeshSamplingRegionMaterialFilter> MaterialFilters;
	public TArray<FSkeletalMeshSamplingRegionBoneFilter> BoneFilters;
}
