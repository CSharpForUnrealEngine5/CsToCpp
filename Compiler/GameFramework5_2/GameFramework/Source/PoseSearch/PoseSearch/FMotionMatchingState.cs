namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchLibrary.h")]
public partial struct FMotionMatchingState {
	public float ElapsedPoseJumpTime;
	public float WantedPlayRate;
	public EMotionMatchingFlags Flags;
	public FTransform RootMotionTransformDelta;
}
