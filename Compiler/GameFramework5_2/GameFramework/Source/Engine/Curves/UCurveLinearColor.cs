#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/CurveLinearColor.h")]
public partial class UCurveLinearColor : UCurveBase {
// CurveLinearColor
	public FRichCurve FloatCurves;
	public  FLinearColor GetLinearColorValue(float InTime) { return default; }
	public  FLinearColor GetClampedLinearColorValue(float InTime) { return default; }
	public  FLinearColor GetUnadjustedLinearColorValue(float InTime) { return default; }
	public float AdjustHue;
	public float AdjustSaturation;
	public float AdjustBrightness;
	public float AdjustBrightnessCurve;
	public float AdjustVibrance;
	public float AdjustMinAlpha;
	public float AdjustMaxAlpha;
}
