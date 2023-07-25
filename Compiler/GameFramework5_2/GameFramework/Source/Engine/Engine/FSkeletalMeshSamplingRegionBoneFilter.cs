#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMeshSampling.h")]
///<summary>Filter to include or exclude bones and their associated triangles from a sampling region.</summary>
public partial struct FSkeletalMeshSamplingRegionBoneFilter {
// SkeletalMeshSamplingRegionBoneFilter
	public string BoneName;
	public bool bIncludeOrExclude;
	public bool bApplyToChildren;
}
