namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows multiple animations to be blended between based on input parameters</summary>
[CppInclude("AnimNodes/AnimNode_BlendSpaceGraphBase.h")]
public partial struct FAnimNode_BlendSpaceGraphBase {
	public float X;
	public float Y;
	public string GroupName;
	public EAnimGroupRole GroupRole;
	public UBlendSpace BlendSpace;
	public TArray<FPoseLink> SamplePoseLinks;
}
