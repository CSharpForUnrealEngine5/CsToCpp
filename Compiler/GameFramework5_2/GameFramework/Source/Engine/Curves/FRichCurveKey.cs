#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>One key in a rich, editable float curve</summary>
[CppInclude("Curves/RichCurve.h")]
public partial struct FRichCurveKey {
	public ERichCurveInterpMode InterpMode;
	public ERichCurveTangentMode TangentMode;
	public ERichCurveTangentWeightMode TangentWeightMode;
	public float Time;
	public float Value;
	public float ArriveTangent;
	public float ArriveTangentWeight;
	public float LeaveTangent;
	public float LeaveTangentWeight;
}
