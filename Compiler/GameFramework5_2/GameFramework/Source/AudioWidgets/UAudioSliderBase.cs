namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An audio slider widget.</summary>
[CppInclude("AudioSlider.h")]
public partial class UAudioSliderBase : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The normalized linear (0 - 1) slider value.</summary>
	public float Value;
	///<summary>The text label units</summary>
	public FText UnitsText;
	///<summary>The color to draw the text label background.</summary>
	public FLinearColor TextLabelBackgroundColor;
	///<summary>A bindable delegate for the TextLabelBackgroundColor.</summary>
	public FGetLinearColor TextLabelBackgroundColorDelegate;
	///<summary>If true, show text label only on hover; if false always show label.</summary>
	public bool ShowLabelOnlyOnHover;
	///<summary>Whether to show the units part of the text label.</summary>
	public bool ShowUnitsText;
	///<summary>Whether to set the units part of the text label read only.</summary>
	public bool IsUnitsTextReadOnly;
	///<summary>Whether to set the value part of the text label read only.</summary>
	public bool IsValueTextReadOnly;
	///<summary>A bindable delegate to allow logic to drive the value of the widget</summary>
	public FGetFloat ValueDelegate;
	///<summary>The color to draw the slider background.</summary>
	public FLinearColor SliderBackgroundColor;
	///<summary>A bindable delegate for the SliderBackgroundColor.</summary>
	public FGetLinearColor SliderBackgroundColorDelegate;
	///<summary>The color to draw the slider bar.</summary>
	public FLinearColor SliderBarColor;
	///<summary>A bindable delegate for the SliderBarColor.</summary>
	public FGetLinearColor SliderBarColorDelegate;
	///<summary>The color to draw the slider thumb.</summary>
	public FLinearColor SliderThumbColor;
	///<summary>A bindable delegate for the SliderThumbColor.</summary>
	public FGetLinearColor SliderThumbColorDelegate;
	///<summary>The color to draw the widget background.</summary>
	public FLinearColor WidgetBackgroundColor;
	///<summary>A bindable delegate for the WidgetBackgroundColor.</summary>
	public FGetLinearColor WidgetBackgroundColorDelegate;
	///<summary>Get output value from normalized linear (0 - 1) based on internal lin to output mapping.</summary>
	public float GetOutputValue(float InSliderValue) { return default; }
	///<summary>Get normalized linear (0 - 1) value from output based on internal lin to output mapping.</summary>
	public float GetLinValue(float OutputValue) { return default; }
	///<summary>Get normalized linear (0 - 1) slider value from output based on internal lin to output mapping.</summary>
	public float GetSliderValue(float OutputValue) { return default; }
	///<summary>Sets the label background color</summary>
	public void SetTextLabelBackgroundColor(FSlateColor InColor) {}
	///<summary>Sets the units text</summary>
	public void SetUnitsText(FText Units) {}
	///<summary>Sets whether the units text is read only</summary>
	public void SetUnitsTextReadOnly(bool bIsReadOnly) {}
	///<summary>Sets whether the value text is read only</summary>
	public void SetValueTextReadOnly(bool bIsReadOnly) {}
	///<summary>If true, show text label only on hover; if false always show label.</summary>
	public void SetShowLabelOnlyOnHover(bool bShowLabelOnlyOnHover) {}
	///<summary>Sets whether to show the units text</summary>
	public void SetShowUnitsText(bool bShowUnitsText) {}
	///<summary>The slider&#39;s orientation.</summary>
	public EOrientation Orientation;
	///<summary>Called when the value is changed by slider or typing.</summary>
	public FOnFloatValueChangedEvent OnValueChanged;
	///<summary>Sets the slider background color</summary>
	public void SetSliderBackgroundColor(FLinearColor InValue) {}
	///<summary>Sets the slider bar color</summary>
	public void SetSliderBarColor(FLinearColor InValue) {}
	///<summary>Sets the slider thumb color</summary>
	public void SetSliderThumbColor(FLinearColor InValue) {}
	///<summary>Sets the widget background color</summary>
	public void SetWidgetBackgroundColor(FLinearColor InValue) {}
}
