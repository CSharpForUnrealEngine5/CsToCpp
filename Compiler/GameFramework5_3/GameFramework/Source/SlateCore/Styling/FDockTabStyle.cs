namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SDockTab</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FDockTabStyle {
	public FButtonStyle CloseButtonStyle;
	public FSlateBrush NormalBrush;
	public FSlateBrush ColorOverlayTabBrush;
	public FSlateBrush ColorOverlayIconBrush;
	public FSlateBrush ForegroundBrush;
	public FSlateBrush HoveredBrush;
	public FSlateBrush ContentAreaBrush;
	public FSlateBrush TabWellBrush;
	public FTextBlockStyle TabTextStyle;
	public FMargin TabPadding;
	public FDeprecateSlateVector2D IconSize;
	public float OverlapWidth;
	public FSlateColor FlashColor;
	public FSlateColor NormalForegroundColor;
	public FSlateColor HoveredForegroundColor;
	public FSlateColor ActiveForegroundColor;
	public FSlateColor ForegroundForegroundColor;
	public float IconBorderPadding;
}
