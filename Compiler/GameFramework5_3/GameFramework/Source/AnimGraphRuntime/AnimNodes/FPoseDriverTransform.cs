namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Translation and rotation for a particular bone at a particular target</summary>
[CppInclude("AnimNodes/AnimNode_PoseDriver.h")]
public partial struct FPoseDriverTransform {
	public FVector TargetTranslation;
	public FRotator TargetRotation;
}
