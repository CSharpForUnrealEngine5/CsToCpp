#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_PoseDriver.h")]
///<summary>Information about each target in the PoseDriver</summary>
public partial struct FPoseDriverTarget {
// PoseDriverTarget
	public TArray<FPoseDriverTransform> BoneTransforms;
	public FRotator TargetRotation;
	public float TargetScale;
	public ERBFDistanceMethod DistanceMethod;
	public ERBFFunctionType FunctionType;
	public bool bApplyCustomCurve;
	public FRichCurve CustomCurve;
	public string DrivenName;
	public bool bIsHidden;
}
