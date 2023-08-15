namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter to include or exclude bones and their associated triangles from a sampling region.</summary>
[CppInclude("Engine/SkeletalMeshSampling.h")]
public partial struct FSkeletalMeshSamplingRegionBoneFilter {
	public FName BoneName;
	public bool bIncludeOrExclude;
	public bool bApplyToChildren;
}
