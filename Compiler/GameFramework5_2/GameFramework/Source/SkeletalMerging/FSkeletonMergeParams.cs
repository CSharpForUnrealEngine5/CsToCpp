#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct containing all parameters used to perform a Skeleton merge.</summary>
[CppInclude("SkeletalMergingLibrary.h")]
public partial struct FSkeletonMergeParams {
	public TArray<USkeleton> SkeletonsToMerge;
	public bool bMergeSockets;
	public bool bMergeVirtualBones;
	public bool bMergeCurveNames;
	public bool bMergeBlendProfiles;
	public bool bMergeAnimSlotGroups;
	public bool bCheckSkeletonsCompatibility;
}
