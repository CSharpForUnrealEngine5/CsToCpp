#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/SynthKnob.h")]
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
public partial class USynthKnob : UWidget {
// SynthKnob
	public float Value;
	public float StepSize;
	public float MouseSpeed;
	public float MouseFineTuneSpeed;
	public bool ShowTooltipInfo;
	public string ParameterName;
	public string ParameterUnits;
	public FGetFloat ValueDelegate;
	public FSynthKnobStyle WidgetStyle;
	public bool Locked;
	public bool IsFocusable;
	public FOnMouseCaptureBeginEvent OnMouseCaptureBegin;
	public FOnMouseCaptureEndEvent OnMouseCaptureEnd;
	public FOnControllerCaptureBeginEvent OnControllerCaptureBegin;
	public FOnControllerCaptureEndEvent OnControllerCaptureEnd;
	public FOnFloatValueChangedEvent OnValueChanged;
	public  float GetValue() { return default; }
	public  void SetValue(float InValue) {}
	public  void SetLocked(bool InValue) {}
	public  void SetStepSize(float InValue) {}
}
