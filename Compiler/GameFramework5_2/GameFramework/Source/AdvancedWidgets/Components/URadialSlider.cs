#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
[CppInclude("Components/RadialSlider.h")]
public partial class URadialSlider : UWidget {
	///<summary>The slider value to display.</summary>
	public float Value;
	///<summary>A bindable delegate to allow logic to drive the value of the widget</summary>
	public FGetFloat ValueDelegate;
	///<summary>Whether the slider should draw it&#39;s progress bar from a custom value on the slider</summary>
	public bool bUseCustomDefaultValue;
	///<summary>The value where the slider should draw it&#39;s progress bar from, independent of direction</summary>
	public float CustomDefaultValue;
	///<summary>A curve that defines how the slider should be sampled. Default is linear.</summary>
	public FRuntimeFloatCurve SliderRange;
	///<summary>Adds text tags to the radial slider at the value&#39;s position.</summary>
	public TArray<float> ValueTags;
	///<summary>The angle at which the Slider Handle will start.</summary>
	public float SliderHandleStartAngle;
	///<summary>The angle at which the Slider Handle will end.</summary>
	public float SliderHandleEndAngle;
	///<summary>Rotates radial slider by arbitrary offset to support full gamut of configurations.</summary>
	public float AngularOffset;
	///<summary>Start and end of the hand as a ratio to the slider radius (so 0.0 to 1.0 is from the slider center to the handle).</summary>
	public FVector2D HandStartEndRatio;
	///<summary>The progress bar style</summary>
	public FSliderStyle WidgetStyle;
	///<summary>The color to draw the slider bar in.</summary>
	public FLinearColor SliderBarColor;
	///<summary>The color to draw the completed progress of the slider bar in.</summary>
	public FLinearColor SliderProgressColor;
	///<summary>The color to draw the slider handle in.</summary>
	public FLinearColor SliderHandleColor;
	///<summary>The color to draw the center background in.</summary>
	public FLinearColor CenterBackgroundColor;
	///<summary>Whether the handle is interactive or fixed.</summary>
	public bool Locked;
	///<summary>Sets new value if mouse position is greater/less than half the step size.</summary>
	public bool MouseUsesStep;
	///<summary>Sets whether we have to lock input to change the slider value.</summary>
	public bool RequiresControllerLock;
	///<summary>The amount to adjust the value by, when using a controller or keyboard</summary>
	public float StepSize;
	///<summary>Should the slider be focusable?</summary>
	public bool IsFocusable;
	///<summary>Whether the value is changed when dragging vertically as opposed to along the radial curve.</summary>
	public bool UseVerticalDrag;
	///<summary>Whether to show the slider handle (thumb).</summary>
	public bool ShowSliderHandle;
	///<summary>Whether to show the slider hand.</summary>
	public bool ShowSliderHand;
	///<summary>Invoked when the mouse is pressed and a capture begins.</summary>
	public FOnMouseCaptureBeginEvent OnMouseCaptureBegin;
	///<summary>Invoked when the mouse is released and a capture ends.</summary>
	public FOnMouseCaptureEndEvent OnMouseCaptureEnd;
	///<summary>Invoked when the controller capture begins.</summary>
	public FOnControllerCaptureBeginEvent OnControllerCaptureBegin;
	///<summary>Invoked when the controller capture ends.</summary>
	public FOnControllerCaptureEndEvent OnControllerCaptureEnd;
	///<summary>Called when the value is changed by slider or typing.</summary>
	public FOnFloatValueChangedEvent OnValueChanged;
	///<summary>Gets the current value of the slider.</summary>
	public  float GetValue() { return default; }
	///<summary>Gets the current custom default value of the slider.</summary>
	public  float GetCustomDefaultValue() { return default; }
	///<summary>Get the current raw slider alpha from 0 to 1</summary>
	public  float GetNormalizedSliderHandlePosition() { return default; }
	///<summary>Sets the current value of the slider.</summary>
	public  void SetValue(float InValue) {}
	///<summary>Sets the current custom default value of the slider.</summary>
	public  void SetCustomDefaultValue(float InValue) {}
	///<summary>Sets the curve for the slider range</summary>
	public  void SetSliderRange(FRuntimeFloatCurve InSliderRange) {}
	///<summary>Adds value tags to the slider.</summary>
	public  void SetValueTags(TArray<float> InValueTags) {}
	///<summary>Sets the minimum angle of the slider.</summary>
	public  void SetSliderHandleStartAngle(float InValue) {}
	///<summary>Sets the maximum angle of the slider.</summary>
	public  void SetSliderHandleEndAngle(float InValue) {}
	///<summary>Sets the Angular Offset for the slider.</summary>
	public  void SetAngularOffset(float InValue) {}
	///<summary>Sets the start and end of the hand as a ratio to the slider radius (so 0.0 to 1.0 is from the slider center to the handle).</summary>
	public  void SetHandStartEndRatio(FVector2D InValue) {}
	///<summary>Sets the handle to be interactive or fixed</summary>
	public  void SetLocked(bool InValue) {}
	///<summary>Sets the amount to adjust the value by, when using a controller or keyboard</summary>
	public  void SetStepSize(float InValue) {}
	///<summary>Sets the color of the slider bar</summary>
	public  void SetSliderBarColor(FLinearColor InValue) {}
	///<summary>Sets the progress color of the slider bar</summary>
	public  void SetSliderProgressColor(FLinearColor InValue) {}
	///<summary>Sets the color of the handle bar</summary>
	public  void SetSliderHandleColor(FLinearColor InValue) {}
	///<summary>Sets the color of the slider bar</summary>
	public  void SetCenterBackgroundColor(FLinearColor InValue) {}
	///<summary>Set whether the value is changed when dragging vertically as opposed to along the radial curve.</summary>
	public  void SetUseVerticalDrag(bool InUseVerticalDrag) {}
	///<summary>Whether to show the slider handle (thumb).</summary>
	public  void SetShowSliderHandle(bool InShowSliderHandle) {}
	///<summary>Whether to show the slider hand.</summary>
	public  void SetShowSliderHand(bool InShowSliderHand) {}
}
