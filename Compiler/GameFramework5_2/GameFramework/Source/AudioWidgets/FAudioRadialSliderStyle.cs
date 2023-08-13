namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an Audio Radial Slider</summary>
[CppInclude("AudioWidgetsSlateTypes.h")]
public partial struct FAudioRadialSliderStyle {
	public FAudioTextBoxStyle TextBoxStyle;
	public FSlateColor CenterBackgroundColor;
	public FSlateColor SliderBarColor;
	public FSlateColor SliderProgressColor;
	public float LabelPadding;
	public float DefaultSliderRadius;
}
