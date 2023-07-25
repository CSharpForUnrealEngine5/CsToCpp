#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlendSpaceAnalysis.h")]
public partial class UEulerAnalysisProperties : UAnalysisProperties {
// EulerAnalysisProperties
	public EAnalysisEulerAxis FunctionAxis;
	public FBoneSocketTarget BoneSocket;
	public EAnalysisLinearAxis BoneFacingAxis;
	public EAnalysisLinearAxis BoneRightAxis;
	public EAnalysisSpace Space;
	public FBoneSocketTarget SpaceBoneSocket;
	public EAnalysisLinearAxis CharacterFacingAxis;
	public EAnalysisLinearAxis CharacterUpAxis;
	public float StartTimeFraction;
	public float EndTimeFraction;
}
