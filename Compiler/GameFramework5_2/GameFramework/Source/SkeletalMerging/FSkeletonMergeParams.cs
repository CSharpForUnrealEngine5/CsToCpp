#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMergingLibrary.h")]
///<summary>Struct containing all parameters used to perform a Skeleton merge.</summary>
public partial struct FSkeletonMergeParams {
// SkeletonMergeParams
	public TArray<USkeleton> SkeletonsToMerge;
	public bool bMergeSockets;
	public bool bMergeVirtualBones;
	public bool bMergeCurveNames;
	public bool bMergeBlendProfiles;
	public bool bMergeAnimSlotGroups;
	public bool bCheckSkeletonsCompatibility;
}
