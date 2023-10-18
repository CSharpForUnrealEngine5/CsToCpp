namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Filters/CurveEditorFFTFilter.h")]
public partial class UCurveEditorFFTFilter : UCurveEditorFilterBase {
	public static UClass StaticClass() {return default;}
	///<summary>Normalized between 0-1. In a low pass filter, the lower the value is the smoother the output. In a high pass filter the higher the value the smoother the output.</summary>
	public float CutoffFrequency;
	///<summary>Which frequencies are allowed through. For example, low-pass will let low frequency through and remove high frequency noise.</summary>
	public ECurveEditorFFTFilterType Type;
	///<summary>Which FFT filter implementation to use.</summary>
	public ECurveEditorFFTFilterClass Response;
	///<summary>The number of samples used to filter in the time domain. It maps how steep the roll off is for the filter.</summary>
	public int Order;
}
