#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionExtractorModifier.h")]
///<summary>Extracts motion from a bone in the animation and bakes it into a curve</summary>
public partial class UMotionExtractorModifier : UAnimationModifier {
// MotionExtractorModifier
	public string BoneName;
	public EMotionExtractor_MotionType MotionType;
	public EMotionExtractor_Axis Axis;
	public bool bRemoveCurveOnRevert;
	public bool bRelativeToFirstFrame;
	public bool bComponentSpace;
	public bool bAbsoluteValue;
	public EMotionExtractor_MathOperation MathOperation;
	public float Modifier;
	public bool bNormalize;
	public int SampleRate;
	public bool bUseCustomCurveName;
	public string CustomCurveName;
}
