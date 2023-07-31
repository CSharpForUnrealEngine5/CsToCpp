#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom animation node that sets the wrist transform of a target pose from a reference pose</summary>
[CppInclude("AnimNode_SteamVRSetWristTransform.h")]
public partial struct FAnimNode_SteamVRSetWristTransform {
	public FPoseLink ReferencePose;
	public EHandSkeleton HandSkeleton;
	public FPoseLink TargetPose;
}
