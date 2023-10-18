namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/AnimNode_MotionMatching.h")]
public partial struct FAnimNode_MotionMatching {
	public FPoseLink Source;
	public UPoseSearchDatabase Database;
	public FPoseSearchQueryTrajectory Trajectory;
	public float TrajectorySpeedMultiplier;
	public float BlendTime;
	public int MaxActiveBlends;
	public UBlendProfile BlendProfile;
	public EAlphaBlendOption BlendOption;
	public float PoseJumpThresholdTime;
	public float PoseReselectHistory;
	public float SearchThrottleTime;
	public FFloatInterval PlayRate;
	public bool bResetOnBecomingRelevant;
	public bool bShouldSearch;
	public float YawFromAnimationTrajectoryBlendTime;
	public float YawFromAnimationBlendRate;
	public TArray<UPoseSearchDatabase> DatabasesToSearch;
	public bool bIgnoreForRelevancyTest;
}
