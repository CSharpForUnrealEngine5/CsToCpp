#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_BlendListBase.h")]
///<summary>Blend list node; has many children</summary>
public partial struct FAnimNode_BlendListBase {
// AnimNode_BlendListBase
	public TArray<FPoseLink> BlendPose;
	public TArray<float> BlendTime;
	public EBlendListTransitionType TransitionType;
	public EAlphaBlendOption BlendType;
	public bool bResetChildOnActivation;
	public UCurveFloat CustomBlendCurve;
	public UBlendProfile BlendProfile;
}
