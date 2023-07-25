#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioRadialSlider.h")]
///<summary>An audio radial slider widget.</summary>
public partial class UAudioRadialSlider : UWidget {
// AudioRadialSlider
	public float Value;
	public FGetFloat ValueDelegate;
	public byte WidgetLayout;
	public FLinearColor CenterBackgroundColor;
	public FLinearColor SliderProgressColor;
	public FLinearColor SliderBarColor;
	public FVector2D HandStartEndRatio;
	public string UnitsText;
	public FLinearColor TextLabelBackgroundColor;
	public bool ShowLabelOnlyOnHover;
	public bool ShowUnitsText;
	public bool IsUnitsTextReadOnly;
	public bool IsValueTextReadOnly;
	public float SliderThickness;
	public FVector2D OutputRange;
	public FOnAudioRadialSliderValueChangedEvent OnValueChanged;
	public float GetOutputValue(float InSliderValue) { return default; }
	public float GetSliderValue(float OutputValue) { return default; }
	public void SetWidgetLayout(EAudioRadialSliderLayout InLayout) {}
	public void SetCenterBackgroundColor(FLinearColor InValue) {}
	public void SetSliderProgressColor(FLinearColor InValue) {}
	public void SetSliderBarColor(FLinearColor InValue) {}
	public void SetHandStartEndRatio(FVector2D InHandStartEndRatio) {}
	public void SetTextLabelBackgroundColor(FSlateColor InColor) {}
	public void SetUnitsText(string Units) {}
	public void SetUnitsTextReadOnly(bool bIsReadOnly) {}
	public void SetValueTextReadOnly(bool bIsReadOnly) {}
	public void SetShowLabelOnlyOnHover(bool bShowLabelOnlyOnHover) {}
	public void SetShowUnitsText(bool bShowUnitsText) {}
	public void SetSliderThickness(float InThickness) {}
	public void SetOutputRange(FVector2D InOutputRange) {}
}
