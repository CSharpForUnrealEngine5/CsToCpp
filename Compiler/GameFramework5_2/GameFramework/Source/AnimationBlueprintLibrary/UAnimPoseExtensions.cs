#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimPose.h")]
///<summary>Script exposed functionality for populating, retrieving data from and setting data on FAnimPose</summary>
public partial class UAnimPoseExtensions : UBlueprintFunctionLibrary {
// AnimPoseExtensions
	public static bool IsValid(FAnimPose Pose) { return default; }
	public static void GetBoneNames(FAnimPose Pose,TArray<string> Bones) {}
	public static FTransform GetBonePose(FAnimPose Pose,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public static void SetBonePose(FAnimPose Pose,FTransform Transform,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) {}
	public static FTransform GetRefBonePose(FAnimPose Pose,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public static FTransform GetRelativeTransform(FAnimPose Pose,string FromBoneName,string ToBoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public static FTransform GetRelativeToRefPoseTransform(FAnimPose Pose,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public static FTransform GetRefPoseRelativeTransform(FAnimPose Pose,string FromBoneName,string ToBoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	public static void GetAnimPoseAtTime(UAnimSequenceBase AnimationSequenceBase,double Time,FAnimPoseEvaluationOptions EvaluationOptions,FAnimPose Pose) {}
	public static void GetAnimPoseAtFrame(UAnimSequenceBase AnimationSequenceBase,int FrameIndex,FAnimPoseEvaluationOptions EvaluationOptions,FAnimPose Pose) {}
	public static void EvaluateAnimationBlueprintWithInputPose(FAnimPose InputPose,USkeletalMesh TargetSkeletalMesh,UAnimBlueprint AnimationBlueprint,FAnimPose OutPose) {}
	public static void GetReferencePose(USkeleton Skeleton,FAnimPose OutPose) {}
	public static void GetCurveNames(FAnimPose Pose,TArray<string> Curves) {}
	public static float GetCurveWeight(FAnimPose Pose,string CurveName) { return default; }
}
