#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
[CppInclude("AnalogSlider.h")]
public partial class UAnalogSlider : USlider {
	///<summary>Called when the value is changed by slider or typing.</summary>
	public FOnFloatValueChangedEvent OnAnalogCapture;
}
