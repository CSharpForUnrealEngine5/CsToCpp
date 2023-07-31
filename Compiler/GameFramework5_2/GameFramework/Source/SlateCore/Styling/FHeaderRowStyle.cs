#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SHeaderRow</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FHeaderRowStyle {
	public FTableColumnHeaderStyle ColumnStyle;
	public FTableColumnHeaderStyle LastColumnStyle;
	public FSplitterStyle ColumnSplitterStyle;
	public float SplitterHandleSize;
	public FSlateBrush BackgroundBrush;
	public FSlateColor ForegroundColor;
	public FSlateBrush HorizontalSeparatorBrush;
	public float HorizontalSeparatorThickness;
}
