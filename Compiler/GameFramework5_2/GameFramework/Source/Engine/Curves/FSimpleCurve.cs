#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A rich, editable float curve</summary>
[CppInclude("Curves/SimpleCurve.h")]
public partial struct FSimpleCurve {
	public ERichCurveInterpMode InterpMode;
	public TArray<FSimpleCurveKey> Keys;
}
