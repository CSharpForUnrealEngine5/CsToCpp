#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Slider.h")]
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
public partial class USlider : UWidget {
// Slider
	public float Value;
	public FGetFloat ValueDelegate;
	public float MinValue;
	public float MaxValue;
	public FSliderStyle WidgetStyle;
	public byte Orientation;
	public FLinearColor SliderBarColor;
	public FLinearColor SliderHandleColor;
	public bool IndentHandle;
	public bool Locked;
	public bool MouseUsesStep;
	public bool RequiresControllerLock;
	public float StepSize;
	public bool IsFocusable;
	public FOnMouseCaptureBeginEvent OnMouseCaptureBegin;
	public FOnMouseCaptureEndEvent OnMouseCaptureEnd;
	public FOnControllerCaptureBeginEvent OnControllerCaptureBegin;
	public FOnControllerCaptureEndEvent OnControllerCaptureEnd;
	public FOnFloatValueChangedEvent OnValueChanged;
	public float GetValue() { return default; }
	public float GetNormalizedValue() { return default; }
	public void SetValue(float InValue) {}
	public void SetMinValue(float InValue) {}
	public void SetMaxValue(float InValue) {}
	public void SetIndentHandle(bool InValue) {}
	public void SetLocked(bool InValue) {}
	public void SetStepSize(float InValue) {}
	public void SetSliderBarColor(FLinearColor InValue) {}
	public void SetSliderHandleColor(FLinearColor InValue) {}
}
