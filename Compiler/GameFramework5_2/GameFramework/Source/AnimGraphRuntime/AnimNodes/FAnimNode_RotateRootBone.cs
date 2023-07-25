#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_RotateRootBone.h")]
///<summary>@TODO: Comment</summary>
public partial struct FAnimNode_RotateRootBone {
// AnimNode_RotateRootBone
	public FPoseLink BasePose;
	public float Pitch;
	public float Yaw;
	public FInputScaleBiasClamp PitchScaleBiasClamp;
	public FInputScaleBiasClamp YawScaleBiasClamp;
	public FRotator MeshToComponent;
}
