#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter to include or exclude bones and their associated triangles from a sampling region.</summary>
[CppInclude("Engine/SkeletalMeshSampling.h")]
public partial struct FSkeletalMeshSamplingRegionBoneFilter {
	public string BoneName;
	public bool bIncludeOrExclude;
	public bool bApplyToChildren;
}
