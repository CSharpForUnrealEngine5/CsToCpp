#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/CurveVector.h")]
public partial class UCurveVector : UCurveBase {
	public static UClass StaticClass() {return default;}
	///<summary>Keyframe data, one curve for X, Y and Z</summary>
	public FRichCurve FloatCurves;
	///<summary>Evaluate this float curve at the specified time</summary>
	public  FVector GetVectorValue(float InTime) { return default; }
}
