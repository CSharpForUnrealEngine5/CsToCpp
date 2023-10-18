namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FToolkitWidgetStyle is the FSlateWidgetStyle that defines the styling of a ToolkitWidget</summary>
[CppInclude("FToolkitWidgetStyle.h")]
public partial struct FToolkitWidgetStyle {
	public FSlateBrush TitleBackgroundBrush;
	public FSlateBrush ToolDetailsBackgroundBrush;
	public FSlateColor TitleForegroundColor;
	public FMargin TitlePadding;
	public FMargin ActiveToolTitleBorderPadding;
	public FMargin ToolContextTextBlockPadding;
	public FSlateFontInfo TitleFont;
}
