namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an STextBlock</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FTextBlockStyle {
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
