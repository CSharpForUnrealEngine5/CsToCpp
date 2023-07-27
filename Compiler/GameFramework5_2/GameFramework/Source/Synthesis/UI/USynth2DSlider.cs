#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/Synth2DSlider.h")]
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
public partial class USynth2DSlider : UWidget {
// Synth2DSlider
	public float ValueX;
	public float ValueY;
	public FGetFloat ValueXDelegate;
	public FGetFloat ValueYDelegate;
	public FSynth2DSliderStyle WidgetStyle;
	public FLinearColor SliderHandleColor;
	public bool IndentHandle;
	public bool Locked;
	public float StepSize;
	public bool IsFocusable;
	public FOnMouseCaptureBeginEventSynth2D OnMouseCaptureBegin;
	public FOnMouseCaptureEndEventSynth2D OnMouseCaptureEnd;
	public FOnControllerCaptureBeginEventSynth2D OnControllerCaptureBegin;
	public FOnControllerCaptureEndEventSynth2D OnControllerCaptureEnd;
	public FOnFloatValueChangedEventSynth2D OnValueChangedX;
	public FOnFloatValueChangedEventSynth2D OnValueChangedY;
	public  FVector2D GetValue() { return default; }
	public  void SetValue(FVector2D InValue) {}
	public  void SetIndentHandle(bool InValue) {}
	public  void SetLocked(bool InValue) {}
	public  void SetStepSize(float InValue) {}
	public  void SetSliderHandleColor(FLinearColor InValue) {}
}
