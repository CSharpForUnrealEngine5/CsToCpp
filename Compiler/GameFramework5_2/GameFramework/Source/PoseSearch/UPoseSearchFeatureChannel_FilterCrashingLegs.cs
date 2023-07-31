#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>the idea is to calculate the angle between the direction from LeftThigh position to RightThigh position and the direction from LeftFoot position to RightFoot position, and divide it by PI to have values in range [-1,1]</summary>
[CppInclude("PoseSearchFeatureChannel_FilterCrashingLegs.h")]
public partial class UPoseSearchFeatureChannel_FilterCrashingLegs : UPoseSearchFeatureChannel {
	///<summary>LeftThigh</summary>
	public FBoneReference LeftThigh;
	///<summary>RightThigh</summary>
	public FBoneReference RightThigh;
	///<summary>LeftFoot</summary>
	public FBoneReference LeftFoot;
	///<summary>RightFoot</summary>
	public FBoneReference RightFoot;
	///<summary>Weight</summary>
	public float Weight;
	///<summary>LeftThighIdx</summary>
	public short LeftThighIdx;
	///<summary>RightThighIdx</summary>
	public short RightThighIdx;
	///<summary>LeftFootIdx</summary>
	public short LeftFootIdx;
	///<summary>RightFootIdx</summary>
	public short RightFootIdx;
	///<summary>InputQueryPose</summary>
	public EInputQueryPose InputQueryPose;
	///<summary>AllowedTolerance</summary>
	public float AllowedTolerance;
}
