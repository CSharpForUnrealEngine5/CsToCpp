namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of a toolbar</summary>
[CppInclude("Styling/ToolBarStyle.h")]
public partial struct FToolBarStyle {
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
	public float UniformBlockWidth;
	public float UniformBlockHeight;
	public int NumColumns;
	public FMargin IconPadding;
	public FMargin SeparatorPadding;
	public FMargin ComboButtonPadding;
	public FMargin ButtonPadding;
	public FMargin CheckBoxPadding;
	public FMargin BlockPadding;
	public FMargin IndentedBlockPadding;
	public FMargin BackgroundPadding;
	public FDeprecateSlateVector2D IconSize;
	public bool bShowLabels;
	public float ButtonContentMaxWidth;
	public float ButtonContentFillWidth;
	public FMargin IconPaddingWithVisibleLabel;
	public FMargin IconPaddingWithCollapsedLabel;
}
