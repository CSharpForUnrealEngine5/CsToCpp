#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom animation node to retrieve poses from the Skeletal Input System</summary>
[CppInclude("AnimNode_SteamVRInputAnimPose.h")]
public partial struct FAnimNode_SteamVRInputAnimPose {
	public EMotionRange MotionRange;
	public EHand Hand;
	public EHandSkeleton HandSkeleton;
	public bool Mirror;
	public FSteamVRSkeletonTransform SteamVRSkeletalTransform;
	public FUE4RetargettingRefs UE4RetargettingRefs;
}
