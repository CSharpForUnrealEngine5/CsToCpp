#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionAnalysis.h")]
public partial class URootMotionAnalysisProperties : UAnalysisProperties {
// RootMotionAnalysisProperties
	public EAnalysisRootMotionAxis FunctionAxis;
	public FBoneSocketTarget BoneSocket;
	public EAnalysisSpace Space;
	public FBoneSocketTarget SpaceBoneSocket;
	public EAnalysisLinearAxis CharacterFacingAxis;
	public EAnalysisLinearAxis CharacterUpAxis;
	public float StartTimeFraction;
	public float EndTimeFraction;
}
