namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response Curve Exponential</summary>
[CppInclude("InputModifiers.h")]
public partial class UInputModifierResponseCurveExponential : UInputModifier {
	public static UClass StaticClass() {return default;}
	///<summary>CurveExponent</summary>
	public FVector CurveExponent;
}
