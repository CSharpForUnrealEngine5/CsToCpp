#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/RadialSlider.h")]
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
public partial class URadialSlider : UWidget {
// RadialSlider
	public float Value;
	public FGetFloat ValueDelegate;
	public bool bUseCustomDefaultValue;
	public float CustomDefaultValue;
	public FRuntimeFloatCurve SliderRange;
	public TArray<float> ValueTags;
	public float SliderHandleStartAngle;
	public float SliderHandleEndAngle;
	public float AngularOffset;
	public FVector2D HandStartEndRatio;
	public FSliderStyle WidgetStyle;
	public FLinearColor SliderBarColor;
	public FLinearColor SliderProgressColor;
	public FLinearColor SliderHandleColor;
	public FLinearColor CenterBackgroundColor;
	public bool Locked;
	public bool MouseUsesStep;
	public bool RequiresControllerLock;
	public float StepSize;
	public bool IsFocusable;
	public bool UseVerticalDrag;
	public bool ShowSliderHandle;
	public bool ShowSliderHand;
	public FOnMouseCaptureBeginEvent OnMouseCaptureBegin;
	public FOnMouseCaptureEndEvent OnMouseCaptureEnd;
	public FOnControllerCaptureBeginEvent OnControllerCaptureBegin;
	public FOnControllerCaptureEndEvent OnControllerCaptureEnd;
	public FOnFloatValueChangedEvent OnValueChanged;
	public  float GetValue() { return default; }
	public  float GetCustomDefaultValue() { return default; }
	public  float GetNormalizedSliderHandlePosition() { return default; }
	public  void SetValue(float InValue) {}
	public  void SetCustomDefaultValue(float InValue) {}
	public  void SetSliderRange(FRuntimeFloatCurve InSliderRange) {}
	public  void SetValueTags(TArray<float> InValueTags) {}
	public  void SetSliderHandleStartAngle(float InValue) {}
	public  void SetSliderHandleEndAngle(float InValue) {}
	public  void SetAngularOffset(float InValue) {}
	public  void SetHandStartEndRatio(FVector2D InValue) {}
	public  void SetLocked(bool InValue) {}
	public  void SetStepSize(float InValue) {}
	public  void SetSliderBarColor(FLinearColor InValue) {}
	public  void SetSliderProgressColor(FLinearColor InValue) {}
	public  void SetSliderHandleColor(FLinearColor InValue) {}
	public  void SetCenterBackgroundColor(FLinearColor InValue) {}
	public  void SetUseVerticalDrag(bool InUseVerticalDrag) {}
	public  void SetShowSliderHandle(bool InShowSliderHandle) {}
	public  void SetShowSliderHand(bool InShowSliderHand) {}
}
