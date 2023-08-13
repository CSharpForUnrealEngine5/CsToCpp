namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SSpinBox</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FSpinBoxStyle {
	public FSlateBrush BackgroundBrush;
	public FSlateBrush ActiveBackgroundBrush;
	public FSlateBrush HoveredBackgroundBrush;
	public FSlateBrush ActiveFillBrush;
	public FSlateBrush HoveredFillBrush;
	public FSlateBrush InactiveFillBrush;
	public FSlateBrush ArrowsImage;
	public FSlateColor ForegroundColor;
	public FMargin TextPadding;
	public FMargin InsetPadding;
}
