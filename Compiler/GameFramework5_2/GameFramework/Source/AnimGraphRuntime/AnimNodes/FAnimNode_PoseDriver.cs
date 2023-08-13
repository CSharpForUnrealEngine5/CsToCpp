namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RBF based orientation driver</summary>
[CppInclude("AnimNodes/AnimNode_PoseDriver.h")]
public partial struct FAnimNode_PoseDriver {
	public FPoseLink SourcePose;
	public TArray<FBoneReference> SourceBones;
	public TArray<FBoneReference> OnlyDriveBones;
	public TArray<FPoseDriverTarget> PoseTargets;
	public FBoneReference EvalSpaceBone;
	public bool bEvalFromRefPose;
	public FRBFParams RBFParams;
	public FBoneReference SourceBone_DEPRECATED;
	public EBoneAxis TwistAxis_DEPRECATED;
	public EPoseDriverType Type_DEPRECATED;
	public float RadialScaling_DEPRECATED;
	public EPoseDriverSource DriveSource;
	public EPoseDriverOutput DriveOutput;
	public bool bOnlyDriveSelectedBones;
	public bool bSoloDrivenOnly;
	public int LODThreshold;
}
