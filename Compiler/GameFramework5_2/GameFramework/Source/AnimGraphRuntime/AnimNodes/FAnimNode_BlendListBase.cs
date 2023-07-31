#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blend list node; has many children</summary>
[CppInclude("AnimNodes/AnimNode_BlendListBase.h")]
public partial struct FAnimNode_BlendListBase {
	public TArray<FPoseLink> BlendPose;
	public TArray<float> BlendTime;
	public EBlendListTransitionType TransitionType;
	public EAlphaBlendOption BlendType;
	public bool bResetChildOnActivation;
	public UCurveFloat CustomBlendCurve;
	public UBlendProfile BlendProfile;
}
