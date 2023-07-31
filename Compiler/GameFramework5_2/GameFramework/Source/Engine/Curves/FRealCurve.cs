#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A rich, editable float curve</summary>
[CppInclude("Curves/RealCurve.h")]
public partial struct FRealCurve {
	public float DefaultValue;
	public ERichCurveExtrapolation PreInfinityExtrap;
	public ERichCurveExtrapolation PostInfinityExtrap;
}
