#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/SimpleCurve.h")]
///<summary>A rich, editable float curve</summary>
public partial struct FSimpleCurve {
// SimpleCurve
	public ERichCurveInterpMode InterpMode;
	public TArray<FSimpleCurveKey> Keys;
}
