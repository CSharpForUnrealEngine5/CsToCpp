namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value in a user define range (between 0..1 by default).</summary>
[CppInclude("AnalogSlider.h")]
public partial class UAnalogSlider : USlider {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the value is changed by slider or typing.</summary>
	public FOnFloatValueChangedEvent OnAnalogCapture;
}
