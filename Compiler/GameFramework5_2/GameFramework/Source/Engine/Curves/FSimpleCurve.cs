namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A rich, editable float curve</summary>
[CppInclude("Curves/SimpleCurve.h")]
public partial struct FSimpleCurve {
	public ERichCurveInterpMode InterpMode;
	public TArray<FSimpleCurveKey> Keys;
}
