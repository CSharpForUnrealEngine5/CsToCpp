namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.</summary>
[CppInclude("UI/SynthKnob.h")]
public partial class USynthKnob : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The volume value to display.</summary>
	public float Value;
	///<summary>The amount to adjust the value by, when using a controller or keyboard</summary>
	public float StepSize;
	///<summary>The speed of the mouse knob control</summary>
	public float MouseSpeed;
	///<summary>The speed of the mouse knob control when fine-tuning the knob</summary>
	public float MouseFineTuneSpeed;
	///<summary>Enable tool tip window to show parameter information while knob turns</summary>
	public bool ShowTooltipInfo;
	///<summary>The name of the pararameter. Will show when knob turns.</summary>
	public FText ParameterName;
	///<summary>The parameter units (e.g. hz). Will append to synth tooltip info.</summary>
	public FText ParameterUnits;
	///<summary>A bindable delegate to allow logic to drive the value of the widget</summary>
	public FGetFloat ValueDelegate;
	///<summary>The synth knob style</summary>
	public FSynthKnobStyle WidgetStyle;
	///<summary>Whether the handle is interactive or fixed.</summary>
	public bool Locked;
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
	public float GetValue() { return default; }
	///<summary>Sets the current value of the slider.</summary>
	public void SetValue(float InValue) {}
	///<summary>Sets the handle to be interactive or fixed</summary>
	public void SetLocked(bool InValue) {}
	///<summary>Sets the amount to adjust the value by, when using a controller or keyboard</summary>
	public void SetStepSize(float InValue) {}
}
