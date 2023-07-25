#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Filters/CurveEditorFFTFilter.h")]
public partial class UCurveEditorFFTFilter : UCurveEditorFilterBase {
// CurveEditorFFTFilter
	public float CutoffFrequency;
	public ECurveEditorFFTFilterType Type;
	public ECurveEditorFFTFilterClass Response;
	public int Order;
}
