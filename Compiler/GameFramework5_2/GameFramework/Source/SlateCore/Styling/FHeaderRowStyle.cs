#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an SHeaderRow</summary>
public partial struct FHeaderRowStyle {
// HeaderRowStyle
	public FTableColumnHeaderStyle ColumnStyle;
	public FTableColumnHeaderStyle LastColumnStyle;
	public FSplitterStyle ColumnSplitterStyle;
	public float SplitterHandleSize;
	public FSlateBrush BackgroundBrush;
	public FSlateColor ForegroundColor;
	public FSlateBrush HorizontalSeparatorBrush;
	public float HorizontalSeparatorThickness;
}
