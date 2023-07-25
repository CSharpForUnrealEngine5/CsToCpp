#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/ToolBarStyle.h")]
///<summary>Represents the appearance of a toolbar</summary>
public partial struct FToolBarStyle {
// ToolBarStyle
	public FSlateBrush BackgroundBrush;
	public FSlateBrush ExpandBrush;
	public FSlateBrush SeparatorBrush;
	public FTextBlockStyle LabelStyle;
	public FEditableTextBoxStyle EditableTextStyle;
	public FCheckBoxStyle ToggleButton;
	public FComboButtonStyle ComboButtonStyle;
	public FButtonStyle SettingsButtonStyle;
	public FComboButtonStyle SettingsComboButton;
	public FCheckBoxStyle SettingsToggleButton;
	public FButtonStyle ButtonStyle;
	public FMargin LabelPadding;
	public FMargin SeparatorPadding;
	public FMargin ComboButtonPadding;
	public FMargin ButtonPadding;
	public FMargin CheckBoxPadding;
	public FMargin BlockPadding;
	public FMargin IndentedBlockPadding;
	public FMargin BackgroundPadding;
	public FDeprecateSlateVector2D IconSize;
	public bool bShowLabels;
}
