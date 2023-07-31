#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchLibrary.h")]
public partial struct FMotionMatchingSettings {
	public float BlendTime;
	public int MaxActiveBlends;
	public UBlendProfile BlendProfile;
	public EAlphaBlendOption BlendOption;
	public float MirrorChangeBlendTime;
	public float PoseJumpThresholdTime;
	public float PoseReselectHistory;
	public float SearchThrottleTime;
	public float PlayRateMin;
	public float PlayRateMax;
}
