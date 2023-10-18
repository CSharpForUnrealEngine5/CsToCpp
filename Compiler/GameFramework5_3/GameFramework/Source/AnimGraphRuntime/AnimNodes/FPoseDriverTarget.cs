namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about each target in the PoseDriver</summary>
[CppInclude("AnimNodes/AnimNode_PoseDriver.h")]
public partial struct FPoseDriverTarget {
	public TArray<FPoseDriverTransform> BoneTransforms;
	public FRotator TargetRotation;
	public float TargetScale;
	public ERBFDistanceMethod DistanceMethod;
	public ERBFFunctionType FunctionType;
	public bool bApplyCustomCurve;
	public FRichCurve CustomCurve;
	public FName DrivenName;
	public bool bIsHidden;
}
