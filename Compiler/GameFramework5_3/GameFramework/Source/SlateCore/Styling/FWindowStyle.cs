namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SWindow</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FWindowStyle {
	public FButtonStyle MinimizeButtonStyle;
	public FButtonStyle MaximizeButtonStyle;
	public FButtonStyle RestoreButtonStyle;
	public FButtonStyle CloseButtonStyle;
	public FTextBlockStyle TitleTextStyle;
	public FSlateBrush ActiveTitleBrush;
	public FSlateBrush InactiveTitleBrush;
	public FSlateBrush FlashTitleBrush;
	public FSlateColor BackgroundColor;
	public FSlateBrush OutlineBrush;
	public FSlateColor OutlineColor;
	public FSlateBrush BorderBrush;
	public FSlateColor BorderColor;
	public FSlateBrush BackgroundBrush;
	public FSlateBrush ChildBackgroundBrush;
	public int WindowCornerRadius;
	public FMargin BorderPadding;
}
