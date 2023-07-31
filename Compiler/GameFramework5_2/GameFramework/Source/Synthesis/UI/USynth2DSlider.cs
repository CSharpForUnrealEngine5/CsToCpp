#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
[CppInclude("UI/Synth2DSlider.h")]
public partial class USynth2DSlider : UWidget {
	///<summary>ValueX</summary>
	public float ValueX;
	///<summary>ValueY</summary>
	public float ValueY;
	///<summary>A bindable delegate to allow logic to drive the value of the widget</summary>
	public FGetFloat ValueXDelegate;
	///<summary>A bindable delegate to allow logic to drive the value of the widget</summary>
	public FGetFloat ValueYDelegate;
	///<summary>The progress bar style</summary>
	public FSynth2DSliderStyle WidgetStyle;
	///<summary>The color to draw the slider handle in.</summary>
	public FLinearColor SliderHandleColor;
	///<summary>Whether the slidable area should be indented to fit the handle.</summary>
	public bool IndentHandle;
	///<summary>Whether the handle is interactive or fixed.</summary>
	public bool Locked;
	///<summary>The amount to adjust the value by, when using a controller or keyboard</summary>
	public float StepSize;
	///<summary>Should the slider be focusable?</summary>
	public bool IsFocusable;
	///<summary>Invoked when the mouse is pressed and a capture begins.</summary>
	public FOnMouseCaptureBeginEventSynth2D OnMouseCaptureBegin;
	///<summary>Invoked when the mouse is released and a capture ends.</summary>
	public FOnMouseCaptureEndEventSynth2D OnMouseCaptureEnd;
	///<summary>Invoked when the controller capture begins.</summary>
	public FOnControllerCaptureBeginEventSynth2D OnControllerCaptureBegin;
	///<summary>Invoked when the controller capture ends.</summary>
	public FOnControllerCaptureEndEventSynth2D OnControllerCaptureEnd;
	///<summary>Called when the value is changed by slider or typing.</summary>
	public FOnFloatValueChangedEventSynth2D OnValueChangedX;
	///<summary>Called when the value is changed by slider or typing.</summary>
	public FOnFloatValueChangedEventSynth2D OnValueChangedY;
	///<summary>Gets the current value of the slider.</summary>
	public  FVector2D GetValue() { return default; }
	///<summary>Sets the current value of the slider.</summary>
	public  void SetValue(FVector2D InValue) {}
	///<summary>Sets if the slidable area should be indented to fit the handle</summary>
	public  void SetIndentHandle(bool InValue) {}
	///<summary>Sets the handle to be interactive or fixed</summary>
	public  void SetLocked(bool InValue) {}
	///<summary>Sets the amount to adjust the value by, when using a controller or keyboard</summary>
	public  void SetStepSize(float InValue) {}
	///<summary>Sets the color of the handle bar</summary>
	public  void SetSliderHandleColor(FLinearColor InValue) {}
}
