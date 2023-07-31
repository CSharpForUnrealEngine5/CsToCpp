#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extracts motion from a bone in the animation and bakes it into a curve</summary>
[CppInclude("MotionExtractorModifier.h")]
public partial class UMotionExtractorModifier : UAnimationModifier {
	///<summary>Bone we are going to generate the curve from</summary>
	public string BoneName;
	///<summary>Type of motion to extract</summary>
	public EMotionExtractor_MotionType MotionType;
	///<summary>Axis to get the value from</summary>
	public EMotionExtractor_Axis Axis;
	///<summary>Whether we want to remove the curve when we revert or re-apply modifier</summary>
	public bool bRemoveCurveOnRevert;
	///<summary>Whether to extract the bone transforms relative to the first frame in the animation</summary>
	public bool bRelativeToFirstFrame;
	///<summary>Whether to extract the bone pose in component space or local space</summary>
	public bool bComponentSpace;
	///<summary>Whether to convert the final value to absolute (positive)</summary>
	public bool bAbsoluteValue;
	///<summary>Optional math operation to apply on the extracted value before add it to the generated curve</summary>
	public EMotionExtractor_MathOperation MathOperation;
	///<summary>Right operand for the math operation selected</summary>
	public float Modifier;
	///<summary>Whether we want a normalized value (0 - 1)</summary>
	public bool bNormalize;
	///<summary>Rate used to sample the animation</summary>
	public int SampleRate;
	///<summary>Whether we want to specify a custom name for the curve. If false, the name of the curve will be auto generated based on the data we are going to extract</summary>
	public bool bUseCustomCurveName;
	///<summary>Custom name for the curve we are going to generate.</summary>
	public string CustomCurveName;
}
