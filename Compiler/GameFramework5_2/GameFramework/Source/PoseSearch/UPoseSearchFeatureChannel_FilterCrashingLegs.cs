#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_FilterCrashingLegs.h")]
///<summary>the idea is to calculate the angle between the direction from LeftThigh position to RightThigh position and the direction from LeftFoot position to RightFoot position, and divide it by PI to have values in range [-1,1]</summary>
public partial class UPoseSearchFeatureChannel_FilterCrashingLegs : UPoseSearchFeatureChannel {
// PoseSearchFeatureChannel_FilterCrashingLegs
	public FBoneReference LeftThigh;
	public FBoneReference RightThigh;
	public FBoneReference LeftFoot;
	public FBoneReference RightFoot;
	public float Weight;
	public short LeftThighIdx;
	public short RightThighIdx;
	public short LeftFootIdx;
	public short RightFootIdx;
	public EInputQueryPose InputQueryPose;
	public float AllowedTolerance;
}
