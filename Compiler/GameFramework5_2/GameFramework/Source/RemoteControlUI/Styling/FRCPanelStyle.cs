#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an RC Panel.</summary>
[CppInclude("Styling/RemoteControlStyles.h")]
public partial struct FRCPanelStyle {
	public FSlateBrush ContentAreaBrush;
	public FSlateBrush ContentAreaBrushDark;
	public FSlateBrush ContentAreaBrushLight;
	public FButtonStyle FlatButtonStyle;
	public FMargin HeaderRowPadding;
	public FHeaderRowStyle HeaderRowStyle;
	public FTextBlockStyle HeaderTextStyle;
	public FVector2D IconSize;
	public FMargin PanelPadding;
	public FTextBlockStyle PanelTextStyle;
	public FTextBlockStyle SectionHeaderTextStyle;
	public FSlateBrush SectionHeaderBrush;
	public FTableRowStyle TableRowStyle;
	public FTableViewStyle TableViewStyle;
	public FCheckBoxStyle SwitchButtonStyle;
	public FCheckBoxStyle ToggleButtonStyle;
	public float SplitterHandleSize;
}
