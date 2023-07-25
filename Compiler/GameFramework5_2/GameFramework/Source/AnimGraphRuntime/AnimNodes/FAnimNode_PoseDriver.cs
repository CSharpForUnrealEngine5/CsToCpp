#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_PoseDriver.h")]
///<summary>RBF based orientation driver</summary>
public partial struct FAnimNode_PoseDriver {
// AnimNode_PoseDriver
	public FPoseLink SourcePose;
	public TArray<FBoneReference> SourceBones;
	public TArray<FBoneReference> OnlyDriveBones;
	public TArray<FPoseDriverTarget> PoseTargets;
	public FBoneReference EvalSpaceBone;
	public bool bEvalFromRefPose;
	public FRBFParams RBFParams;
	public FBoneReference SourceBone_DEPRECATED;
	public byte TwistAxis_DEPRECATED;
	public EPoseDriverType Type_DEPRECATED;
	public float RadialScaling_DEPRECATED;
	public EPoseDriverSource DriveSource;
	public EPoseDriverOutput DriveOutput;
	public bool bOnlyDriveSelectedBones;
	public bool bSoloDrivenOnly;
	public int LODThreshold;
}
