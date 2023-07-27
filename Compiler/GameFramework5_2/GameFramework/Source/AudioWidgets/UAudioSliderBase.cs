#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioSlider.h")]
///<summary>An audio slider widget.</summary>
public partial class UAudioSliderBase : UWidget {
// AudioSliderBase
	public float Value;
	public string UnitsText;
	public FLinearColor TextLabelBackgroundColor;
	public FGetLinearColor TextLabelBackgroundColorDelegate;
	public bool ShowLabelOnlyOnHover;
	public bool ShowUnitsText;
	public bool IsUnitsTextReadOnly;
	public bool IsValueTextReadOnly;
	public FGetFloat ValueDelegate;
	public FLinearColor SliderBackgroundColor;
	public FGetLinearColor SliderBackgroundColorDelegate;
	public FLinearColor SliderBarColor;
	public FGetLinearColor SliderBarColorDelegate;
	public FLinearColor SliderThumbColor;
	public FGetLinearColor SliderThumbColorDelegate;
	public FLinearColor WidgetBackgroundColor;
	public FGetLinearColor WidgetBackgroundColorDelegate;
	public  float GetOutputValue(float InSliderValue) { return default; }
	public  float GetLinValue(float OutputValue) { return default; }
	public  float GetSliderValue(float OutputValue) { return default; }
	public  void SetTextLabelBackgroundColor(FSlateColor InColor) {}
	public  void SetUnitsText(string Units) {}
	public  void SetUnitsTextReadOnly(bool bIsReadOnly) {}
	public  void SetValueTextReadOnly(bool bIsReadOnly) {}
	public  void SetShowLabelOnlyOnHover(bool bShowLabelOnlyOnHover) {}
	public  void SetShowUnitsText(bool bShowUnitsText) {}
	public byte Orientation;
	public FOnFloatValueChangedEvent OnValueChanged;
	public  void SetSliderBackgroundColor(FLinearColor InValue) {}
	public  void SetSliderBarColor(FLinearColor InValue) {}
	public  void SetSliderThumbColor(FLinearColor InValue) {}
	public  void SetWidgetBackgroundColor(FLinearColor InValue) {}
}
