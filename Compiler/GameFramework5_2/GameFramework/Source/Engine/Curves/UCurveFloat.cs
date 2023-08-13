namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/CurveFloat.h")]
public partial class UCurveFloat : UCurveBase {
	public static UClass StaticClass() {return default;}
	///<summary>Keyframe data</summary>
	public FRichCurve FloatCurve;
	///<summary>Flag to represent event curve</summary>
	public bool bIsEventCurve;
	///<summary>Evaluate this float curve at the specified time</summary>
	public float GetFloatValue(float InTime) { return default; }
}
