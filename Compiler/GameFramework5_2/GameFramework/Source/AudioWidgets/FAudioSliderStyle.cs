#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an Audio Slider</summary>
[CppInclude("AudioWidgetsSlateTypes.h")]
public partial struct FAudioSliderStyle {
	public FSliderStyle SliderStyle;
	public FAudioTextBoxStyle TextBoxStyle;
	public FSlateBrush WidgetBackgroundImage;
	public FSlateColor SliderBackgroundColor;
	public FVector2D SliderBackgroundSize;
	public float LabelPadding;
	public FSlateColor SliderBarColor;
	public FSlateColor SliderThumbColor;
	public FSlateColor WidgetBackgroundColor;
}
