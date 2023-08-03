#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An audio radial slider widget.</summary>
[CppInclude("AudioRadialSlider.h")]
public partial class UAudioRadialSlider : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The normalized linear (0 - 1) slider value position.</summary>
	public float Value;
	///<summary>A bindable delegate to allow logic to drive the value of the widget</summary>
	public FGetFloat ValueDelegate;
	///<summary>The layout of the widget (position of text label).</summary>
	public EAudioRadialSliderLayout WidgetLayout;
	///<summary>The color to draw the widget background.</summary>
	public FLinearColor CenterBackgroundColor;
	///<summary>The color to draw the slider progress bar in.</summary>
	public FLinearColor SliderProgressColor;
	///<summary>The color to draw the slider bar in.</summary>
	public FLinearColor SliderBarColor;
	///<summary>Start and end of the hand as a ratio to the slider radius (so 0.0 to 1.0 is from the slider center to the handle).</summary>
	public FVector2D HandStartEndRatio;
	///<summary>The text label units</summary>
	public string UnitsText;
	///<summary>The color to draw the text label background.</summary>
	public FLinearColor TextLabelBackgroundColor;
	///<summary>If true, show text label only on hover; if false always show label.</summary>
	public bool ShowLabelOnlyOnHover;
	///<summary>Whether to show the units part of the text label.</summary>
	public bool ShowUnitsText;
	///<summary>Whether to set the units part of the text label read only.</summary>
	public bool IsUnitsTextReadOnly;
	///<summary>Whether to set the value part of the text label read only.</summary>
	public bool IsValueTextReadOnly;
	///<summary>The slider thickness.</summary>
	public float SliderThickness;
	///<summary>Output range</summary>
	public FVector2D OutputRange;
	///<summary>Called when the value is changed by slider or typing.</summary>
	public FOnAudioRadialSliderValueChangedEvent OnValueChanged;
	///<summary>Get output value from normalized linear (0 - 1) based on internal lin to output mapping.</summary>
	public  float GetOutputValue(float InSliderValue) { return default; }
	///<summary>Get normalized linear (0 - 1) slider value from output based on internal lin to output mapping.</summary>
	public  float GetSliderValue(float OutputValue) { return default; }
	///<summary>Sets the widget layout</summary>
	public  void SetWidgetLayout(EAudioRadialSliderLayout InLayout) {}
	///<summary>Sets the label background color</summary>
	public  void SetCenterBackgroundColor(FLinearColor InValue) {}
	///<summary>Sets the slider progress color</summary>
	public  void SetSliderProgressColor(FLinearColor InValue) {}
	///<summary>Sets the slider bar color</summary>
	public  void SetSliderBarColor(FLinearColor InValue) {}
	///<summary>Sets the start and end of the hand as a ratio to the slider radius (so 0.0 to 1.0 is from the slider center to the handle).</summary>
	public  void SetHandStartEndRatio(FVector2D InHandStartEndRatio) {}
	///<summary>Sets the label background color</summary>
	public  void SetTextLabelBackgroundColor(FSlateColor InColor) {}
	///<summary>Sets the units text</summary>
	public  void SetUnitsText(string Units) {}
	///<summary>Sets whether the units text is read only</summary>
	public  void SetUnitsTextReadOnly(bool bIsReadOnly) {}
	///<summary>Sets whether the value text is read only</summary>
	public  void SetValueTextReadOnly(bool bIsReadOnly) {}
	///<summary>If true, show text label only on hover; if false always show label.</summary>
	public  void SetShowLabelOnlyOnHover(bool bShowLabelOnlyOnHover) {}
	///<summary>Sets whether to show the units text</summary>
	public  void SetShowUnitsText(bool bShowUnitsText) {}
	///<summary>Sets the slider thickness</summary>
	public  void SetSliderThickness(float InThickness) {}
	///<summary>Sets the output range</summary>
	public  void SetOutputRange(FVector2D InOutputRange) {}
}
