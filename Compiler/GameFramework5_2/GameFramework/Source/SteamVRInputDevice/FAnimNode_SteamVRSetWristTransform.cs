#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNode_SteamVRSetWristTransform.h")]
///<summary>Custom animation node that sets the wrist transform of a target pose from a reference pose</summary>
public partial struct FAnimNode_SteamVRSetWristTransform {
// AnimNode_SteamVRSetWristTransform
	public FPoseLink ReferencePose;
	public EHandSkeleton HandSkeleton;
	public FPoseLink TargetPose;
}
