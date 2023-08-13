namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script exposed functionality for populating, retrieving data from and setting data on FAnimPose</summary>
[CppInclude("AnimPose.h")]
public partial class UAnimPoseExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns whether the Anim Pose contains valid data</summary>
	public static bool IsValid(FAnimPose Pose) { return default; }
	///<summary>Returns an array of bone names contained by the pose</summary>
	public static void GetBoneNames(FAnimPose Pose,TArray<string> Bones) {}
	///<summary>Retrieves the transform for the provided bone name from a pose</summary>
	public static FTransform GetBonePose(FAnimPose Pose,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	///<summary>Sets the transform for the provided bone name for a pose</summary>
	public static void SetBonePose(FAnimPose Pose,FTransform Transform,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) {}
	///<summary>Retrieves the reference pose transform for the provided bone name</summary>
	public static FTransform GetRefBonePose(FAnimPose Pose,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	///<summary>Retrieves the relative transform between the two provided bone names</summary>
	public static FTransform GetRelativeTransform(FAnimPose Pose,string FromBoneName,string ToBoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	///<summary>Retrieves the relative transform between reference and animated bone transform</summary>
	public static FTransform GetRelativeToRefPoseTransform(FAnimPose Pose,string BoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	///<summary>Retrieves the relative transform for the reference pose between the two provided bone names</summary>
	public static FTransform GetRefPoseRelativeTransform(FAnimPose Pose,string FromBoneName,string ToBoneName,EAnimPoseSpaces Space/*=EAnimPoseSpaces.Local*/) { return default; }
	///<summary>Evaluates an Animation Sequence Base to generate a valid Anim Pose instance</summary>
	public static void GetAnimPoseAtTime(UAnimSequenceBase AnimationSequenceBase,double Time,FAnimPoseEvaluationOptions EvaluationOptions,FAnimPose Pose) {}
	///<summary>Evaluates an Animation Sequence Base to generate a valid Anim Pose instance</summary>
	public static void GetAnimPoseAtFrame(UAnimSequenceBase AnimationSequenceBase,int FrameIndex,FAnimPoseEvaluationOptions EvaluationOptions,FAnimPose Pose) {}
	///<summary>Evaluates an Animation Blueprint instance, using the provided Anim Pose and its Input Pose value, generating a valid Anim Pose using the result. Warning this function may cause performance issues.</summary>
	public static void EvaluateAnimationBlueprintWithInputPose(FAnimPose InputPose,USkeletalMesh TargetSkeletalMesh,UAnimBlueprint AnimationBlueprint,FAnimPose OutPose) {}
	///<summary>Populates an Anim Pose with the reference poses stored for the provided USkeleton</summary>
	public static void GetReferencePose(USkeleton Skeleton,FAnimPose OutPose) {}
	///<summary>Returns an array of curve names contained by the pose</summary>
	public static void GetCurveNames(FAnimPose Pose,TArray<string> Curves) {}
	///<summary>Returns the weight of an evaluated curve - if found</summary>
	public static float GetCurveWeight(FAnimPose Pose,string CurveName) { return default; }
}
