#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNode_SteamVRInputAnimPose.h")]
///<summary>Custom animation node to retrieve poses from the Skeletal Input System</summary>
public partial struct FAnimNode_SteamVRInputAnimPose {
// AnimNode_SteamVRInputAnimPose
	public EMotionRange MotionRange;
	public EHand Hand;
	public EHandSkeleton HandSkeleton;
	public bool Mirror;
	public FSteamVRSkeletonTransform SteamVRSkeletalTransform;
	public FUE4RetargettingRefs UE4RetargettingRefs;
}
