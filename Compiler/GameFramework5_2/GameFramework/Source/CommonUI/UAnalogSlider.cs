#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalogSlider.h")]
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
public partial class UAnalogSlider : USlider {
// AnalogSlider
	public FOnFloatValueChangedEvent OnAnalogCapture;
}
