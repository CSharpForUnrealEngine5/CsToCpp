namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/CurveLinearColor.h")]
public partial class UCurveLinearColor : UCurveBase {
	public static UClass StaticClass() {return default;}
	///<summary>Keyframe data, one curve for red, green, blue, and alpha</summary>
	public FRichCurve FloatCurves;
	///<summary>GetLinearColorValue</summary>
	public virtual FLinearColor GetLinearColorValue(float InTime) { return default; }
	///<summary>GetClampedLinearColorValue</summary>
	public virtual FLinearColor GetClampedLinearColorValue(float InTime) { return default; }
	///<summary>GetUnadjustedLinearColorValue</summary>
	public FLinearColor GetUnadjustedLinearColorValue(float InTime) { return default; }
	///<summary>Properties for adjusting the color of the gradient</summary>
	public float AdjustHue;
	///<summary>AdjustSaturation</summary>
	public float AdjustSaturation;
	///<summary>AdjustBrightness</summary>
	public float AdjustBrightness;
	///<summary>AdjustBrightnessCurve</summary>
	public float AdjustBrightnessCurve;
	///<summary>AdjustVibrance</summary>
	public float AdjustVibrance;
	///<summary>AdjustMinAlpha</summary>
	public float AdjustMinAlpha;
	///<summary>AdjustMaxAlpha</summary>
	public float AdjustMaxAlpha;
}
