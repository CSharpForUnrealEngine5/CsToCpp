namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@TODO: Comment</summary>
[CppInclude("AnimNodes/AnimNode_RotateRootBone.h")]
public partial struct FAnimNode_RotateRootBone {
	public FPoseLink BasePose;
	public float Pitch;
	public float Yaw;
	public FInputScaleBiasClamp PitchScaleBiasClamp;
	public FInputScaleBiasClamp YawScaleBiasClamp;
	public FRotator MeshToComponent;
}
