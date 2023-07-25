#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchLibrary.h")]
public partial struct FMotionMatchingState {
// MotionMatchingState
	public float ElapsedPoseJumpTime;
	public float WantedPlayRate;
	public EMotionMatchingFlags Flags;
	public FTransform RootMotionTransformDelta;
}
