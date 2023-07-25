#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/RichCurve.h")]
///<summary>Enumerates tangent weight modes.</summary>
public enum ERichCurveTangentWeightMode {
	RCTWM_WeightedNone=0,
	RCTWM_WeightedArrive=1,
	RCTWM_WeightedLeave=2,
	RCTWM_WeightedBoth=3,
}
