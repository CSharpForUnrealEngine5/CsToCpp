#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/RichCurve.h")]
///<summary>Enumerates curve compression options.</summary>
public enum ERichCurveCompressionFormat {
	RCCF_Empty=0,
	RCCF_Constant=1,
	RCCF_Linear=2,
	RCCF_Cubic=3,
	RCCF_Mixed=4,
	RCCF_Weighted=5,
}
