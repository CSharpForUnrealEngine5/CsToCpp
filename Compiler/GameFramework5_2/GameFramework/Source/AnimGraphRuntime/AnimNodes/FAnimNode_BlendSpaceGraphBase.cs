#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_BlendSpaceGraphBase.h")]
///<summary>Allows multiple animations to be blended between based on input parameters</summary>
public partial struct FAnimNode_BlendSpaceGraphBase {
// AnimNode_BlendSpaceGraphBase
	public float X;
	public float Y;
	public string GroupName;
	public byte GroupRole;
	public UBlendSpace BlendSpace;
	public TArray<FPoseLink> SamplePoseLinks;
}
