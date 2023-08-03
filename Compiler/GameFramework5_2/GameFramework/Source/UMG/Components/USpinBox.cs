#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A numerical entry box that allows for direct entry of the number or allows the user to click and slide the number.</summary>
[CppInclude("Components/SpinBox.h")]
public partial class USpinBox : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>FOnSpinBoxValueChangedEvent</summary>
	public  void FOnSpinBoxValueChangedEvent(float InValue) {}
	///<summary>FOnSpinBoxValueCommittedEvent</summary>
	public  void FOnSpinBoxValueCommittedEvent(float InValue,ETextCommit CommitMethod) {}
	///<summary>FOnSpinBoxBeginSliderMovement</summary>
	public  void FOnSpinBoxBeginSliderMovement() {}
	///<summary>Value stored in this spin box</summary>
	public float Value;
	///<summary>A bindable delegate to allow logic to drive the value of the widget</summary>
	public FGetFloat ValueDelegate;
	///<summary>The Style</summary>
	public FSpinBoxStyle WidgetStyle;
	///<summary>The minimum required fractional digits - default 1</summary>
	public int MinFractionalDigits;
	///<summary>The maximum required fractional digits - default 6</summary>
	public int MaxFractionalDigits;
	///<summary>Whether this spin box should use the delta snapping logic for typed values - default false</summary>
	public bool bAlwaysUsesDeltaSnap;
	///<summary>Whether this spin box should have slider feature enabled</summary>
	public bool bEnableSlider;
	///<summary>The amount by which to change the spin box value as the slider moves.</summary>
	public float Delta;
	///<summary>The exponent by which to increase the delta as the mouse moves. 1 is constant (never increases the delta).</summary>
	public float SliderExponent;
	///<summary>Font color and opacity (overrides style)</summary>
	public FSlateFontInfo Font;
	///<summary>The justification the value text should appear as.</summary>
	public ETextJustify Justification;
	///<summary>The minimum width of the spin box</summary>
	public float MinDesiredWidth;
	///<summary>If we&#39;re on a platform that requires a virtual keyboard, what kind of keyboard should this widget use?</summary>
	public EVirtualKeyboardType KeyboardType;
	///<summary>Whether to remove the keyboard focus from the spin box when the value is committed</summary>
	public bool ClearKeyboardFocusOnCommit;
	///<summary>Whether to select the text in the spin box when the value is committed</summary>
	public bool SelectAllTextOnCommit;
	///<summary>ForegroundColor</summary>
	public FSlateColor ForegroundColor;
	///<summary>Called when the value is changed interactively by the user</summary>
	public FOnSpinBoxValueChangedEvent OnValueChanged;
	///<summary>Called when the value is committed. Occurs when the user presses Enter or the text box loses focus.</summary>
	public FOnSpinBoxValueCommittedEvent OnValueCommitted;
	///<summary>Called right before the slider begins to move</summary>
	public FOnSpinBoxBeginSliderMovement OnBeginSliderMovement;
	///<summary>Called right after the slider handle is released by the user</summary>
	public FOnSpinBoxValueChangedEvent OnEndSliderMovement;
	///<summary>Get the current value of the spin box.</summary>
	public  float GetValue() { return default; }
	///<summary>Set the value of the spin box.</summary>
	public  void SetValue(float NewValue) {}
	///<summary>Get the current Min Fractional Digits for the spin box.</summary>
	public  int GetMinFractionalDigits() { return default; }
	///<summary>Set the Min Fractional Digits for the spin box.</summary>
	public  void SetMinFractionalDigits(int NewValue) {}
	///<summary>Get the current Max Fractional Digits for the spin box.</summary>
	public  int GetMaxFractionalDigits() { return default; }
	///<summary>Set the Max Fractional Digits for the spin box.</summary>
	public  void SetMaxFractionalDigits(int NewValue) {}
	///<summary>Get whether the spin box uses delta snap on type.</summary>
	public  bool GetAlwaysUsesDeltaSnap() { return default; }
	///<summary>Set whether the spin box uses delta snap on type.</summary>
	public  void SetAlwaysUsesDeltaSnap(bool bNewValue) {}
	///<summary>Get the current delta for the spin box.</summary>
	public  float GetDelta() { return default; }
	///<summary>Set the delta for the spin box.</summary>
	public  void SetDelta(float NewValue) {}
	///<summary>Get the current minimum value that can be manually set in the spin box.</summary>
	public  float GetMinValue() { return default; }
	///<summary>Set the minimum value that can be manually set in the spin box.</summary>
	public  void SetMinValue(float NewValue) {}
	///<summary>Clear the minimum value that can be manually set in the spin box.</summary>
	public  void ClearMinValue() {}
	///<summary>Get the current maximum value that can be manually set in the spin box.</summary>
	public  float GetMaxValue() { return default; }
	///<summary>Set the maximum value that can be manually set in the spin box.</summary>
	public  void SetMaxValue(float NewValue) {}
	///<summary>Clear the maximum value that can be manually set in the spin box.</summary>
	public  void ClearMaxValue() {}
	///<summary>Get the current minimum value that can be specified using the slider.</summary>
	public  float GetMinSliderValue() { return default; }
	///<summary>Set the minimum value that can be specified using the slider.</summary>
	public  void SetMinSliderValue(float NewValue) {}
	///<summary>Clear the minimum value that can be specified using the slider.</summary>
	public  void ClearMinSliderValue() {}
	///<summary>Get the current maximum value that can be specified using the slider.</summary>
	public  float GetMaxSliderValue() { return default; }
	///<summary>Set the maximum value that can be specified using the slider.</summary>
	public  void SetMaxSliderValue(float NewValue) {}
	///<summary>Clear the maximum value that can be specified using the slider.</summary>
	public  void ClearMaxSliderValue() {}
	///<summary>SetForegroundColor</summary>
	public  void SetForegroundColor(FSlateColor InForegroundColor) {}
	///<summary>Whether the optional MinValue attribute of the widget is set</summary>
	public bool bOverride_MinValue;
	///<summary>Whether the optional MaxValue attribute of the widget is set</summary>
	public bool bOverride_MaxValue;
	///<summary>Whether the optional MinSliderValue attribute of the widget is set</summary>
	public bool bOverride_MinSliderValue;
	///<summary>Whether the optional MaxSliderValue attribute of the widget is set</summary>
	public bool bOverride_MaxSliderValue;
	///<summary>The minimum allowable value that can be manually entered into the spin box</summary>
	public float MinValue;
	///<summary>The maximum allowable value that can be manually entered into the spin box</summary>
	public float MaxValue;
	///<summary>The minimum allowable value that can be specified using the slider</summary>
	public float MinSliderValue;
	///<summary>The maximum allowable value that can be specified using the slider</summary>
	public float MaxSliderValue;
}
