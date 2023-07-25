#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/RichCurve.h")]
///<summary>One key in a rich, editable float curve</summary>
public partial struct FRichCurveKey {
// RichCurveKey
	public byte InterpMode;
	public byte TangentMode;
	public byte TangentWeightMode;
	public float Time;
	public float Value;
	public float ArriveTangent;
	public float ArriveTangentWeight;
	public float LeaveTangent;
	public float LeaveTangentWeight;
}
