namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CurveOps/TriangulateCurvesOp.h")]
public enum ECombineCurvesMethod {
	LeaveSeparate=0,
	Union=1,
	Intersect=2,
	Difference=3,
	ExclusiveOr=4,
}
