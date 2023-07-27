#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/RichCurve.h")]
///<summary>One key in a rich, editable float curve</summary>
public partial struct FRichCurveKey {
// RichCurveKey
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
