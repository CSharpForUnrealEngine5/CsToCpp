namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimPose.h")]
public partial struct FAnimPoseEvaluationOptions {
	public EAnimDataEvalType EvaluationType;
	public bool bShouldRetarget;
	public bool bExtractRootMotion;
	public USkeletalMesh OptionalSkeletalMesh;
	public bool bRetrieveAdditiveAsFullPose;
	public bool bEvaluateCurves;
}
