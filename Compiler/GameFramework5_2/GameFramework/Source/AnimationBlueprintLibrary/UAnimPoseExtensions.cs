#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimPose.h")]
///<summary>Script exposed functionality for populating, retrieving data from and setting data on FAnimPose</summary>
public partial class UAnimPoseExtensions : UBlueprintFunctionLibrary {
// AnimPoseExtensions
	public bool IsValid(FAnimPose Pose) { return default; }
	public void GetBoneNames(FAnimPose Pose,TArray<string> Bones) {}
	public FTransform GetBonePose(FAnimPose Pose,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public void SetBonePose(FAnimPose Pose,FTransform Transform,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) {}
	public FTransform GetRefBonePose(FAnimPose Pose,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public FTransform GetRelativeTransform(FAnimPose Pose,string FromBoneName,string ToBoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public FTransform GetRelativeToRefPoseTransform(FAnimPose Pose,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public FTransform GetRefPoseRelativeTransform(FAnimPose Pose,string FromBoneName,string ToBoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public void GetAnimPoseAtTime(UObject AnimationSequenceBase,double Time,FAnimPoseEvaluationOptions EvaluationOptions,FAnimPose Pose) {}
	public void GetAnimPoseAtFrame(UObject AnimationSequenceBase,int FrameIndex,FAnimPoseEvaluationOptions EvaluationOptions,FAnimPose Pose) {}
	public void EvaluateAnimationBlueprintWithInputPose(FAnimPose InputPose,UObject TargetSkeletalMesh,UObject AnimationBlueprint,FAnimPose OutPose) {}
	public void GetReferencePose(UObject Skeleton,FAnimPose OutPose) {}
	public void GetCurveNames(FAnimPose Pose,TArray<string> Curves) {}
	public float GetCurveWeight(FAnimPose Pose,string CurveName) { return default; }
}
