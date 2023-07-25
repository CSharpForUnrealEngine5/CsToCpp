#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an STextBlock</summary>
public partial struct FTextBlockStyle {
// TextBlockStyle
	public FSlateFontInfo Font;
	public FSlateColor ColorAndOpacity;
	public FDeprecateSlateVector2D ShadowOffset;
	public FLinearColor ShadowColorAndOpacity;
	public FSlateColor SelectedBackgroundColor;
	public FSlateColor HighlightColor;
	public FSlateBrush HighlightShape;
	public FSlateBrush StrikeBrush;
	public FSlateBrush UnderlineBrush;
	public ETextTransformPolicy TransformPolicy;
	public ETextOverflowPolicy OverflowPolicy;
}
