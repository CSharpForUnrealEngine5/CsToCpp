#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/RealCurve.h")]
///<summary>Enumerates extrapolation options.</summary>
public enum ERichCurveExtrapolation {
	RCCE_Cycle=0,
	RCCE_CycleWithOffset=1,
	RCCE_Oscillate=2,
	RCCE_Linear=3,
	RCCE_Constant=4,
	RCCE_None=5,
}
