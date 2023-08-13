namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A rich, editable float curve</summary>
[CppInclude("Curves/RealCurve.h")]
public partial struct FRealCurve {
	public float DefaultValue;
	public ERichCurveExtrapolation PreInfinityExtrap;
	public ERichCurveExtrapolation PostInfinityExtrap;
}
