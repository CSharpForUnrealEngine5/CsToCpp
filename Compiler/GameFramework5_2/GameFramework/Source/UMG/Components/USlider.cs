#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
[CppInclude("Components/Slider.h")]
public partial class USlider : UWidget {
	///<summary>The volume value to display.</summary>
	public float Value;
	///<summary>A bindable delegate to allow logic to drive the value of the widget</summary>
	public FGetFloat ValueDelegate;
	///<summary>The minimum value the slider can be set to.</summary>
	public float MinValue;
	///<summary>The maximum value the slider can be set to.</summary>
	public float MaxValue;
	///<summary>The progress bar style</summary>
	public FSliderStyle WidgetStyle;
	///<summary>The slider&#39;s orientation.</summary>
	public EOrientation Orientation;
	///<summary>The color to draw the slider bar in.</summary>
	public FLinearColor SliderBarColor;
	///<summary>The color to draw the slider handle in.</summary>
	public FLinearColor SliderHandleColor;
	///<summary>Whether the slidable area should be indented to fit the handle.</summary>
	public bool IndentHandle;
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
	///<summary>Get the current value scaled from 0 to 1</summary>
	public  float GetNormalizedValue() { return default; }
	///<summary>Sets the current value of the slider.</summary>
	public  void SetValue(float InValue) {}
	///<summary>Sets the minimum value of the slider.</summary>
	public  void SetMinValue(float InValue) {}
	///<summary>Sets the maximum value of the slider.</summary>
	public  void SetMaxValue(float InValue) {}
	///<summary>Sets if the slidable area should be indented to fit the handle.</summary>
	public  void SetIndentHandle(bool InValue) {}
	///<summary>Sets the handle to be interactive or fixed.</summary>
	public  void SetLocked(bool InValue) {}
	///<summary>Sets the amount to adjust the value by, when using a controller or keyboard.</summary>
	public  void SetStepSize(float InValue) {}
	///<summary>Sets the color of the slider bar.</summary>
	public  void SetSliderBarColor(FLinearColor InValue) {}
	///<summary>Sets the color of the handle bar</summary>
	public  void SetSliderHandleColor(FLinearColor InValue) {}
}
