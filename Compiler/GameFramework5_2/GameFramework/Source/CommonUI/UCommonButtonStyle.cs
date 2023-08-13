namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>---- All properties must be EditDefaultsOnly, BlueprintReadOnly !!! -----</summary>
[CppInclude("CommonButtonBase.h")]
public partial class UCommonButtonStyle : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not the style uses a drop shadow</summary>
	public bool bSingleMaterial;
	///<summary>The normal (un-selected) brush to apply to each size of this button</summary>
	public FSlateBrush SingleMaterialBrush;
	///<summary>The normal (un-selected) brush to apply to each size of this button</summary>
	public FSlateBrush NormalBase;
	///<summary>The normal (un-selected) brush to apply to each size of this button when hovered</summary>
	public FSlateBrush NormalHovered;
	///<summary>The normal (un-selected) brush to apply to each size of this button when pressed</summary>
	public FSlateBrush NormalPressed;
	///<summary>The selected brush to apply to each size of this button</summary>
	public FSlateBrush SelectedBase;
	///<summary>The selected brush to apply to each size of this button when hovered</summary>
	public FSlateBrush SelectedHovered;
	///<summary>The selected brush to apply to each size of this button when pressed</summary>
	public FSlateBrush SelectedPressed;
	///<summary>The disabled brush to apply to each size of this button</summary>
	public FSlateBrush Disabled;
	///<summary>The button content padding to apply for each size</summary>
	public FMargin ButtonPadding;
	///<summary>The custom padding of the button to use for each size</summary>
	public FMargin CustomPadding;
	///<summary>The minimum width of buttons using this style</summary>
	public int MinWidth;
	///<summary>The minimum height of buttons using this style</summary>
	public int MinHeight;
	///<summary>The text style to use when un-selected</summary>
	public UClass NormalTextStyle;
	///<summary>The text style to use when un-selected</summary>
	public UClass NormalHoveredTextStyle;
	///<summary>The text style to use when selected</summary>
	public UClass SelectedTextStyle;
	///<summary>The text style to use when un-selected</summary>
	public UClass SelectedHoveredTextStyle;
	///<summary>The text style to use when disabled</summary>
	public UClass DisabledTextStyle;
	///<summary>The sound to play when the button is pressed</summary>
	public FSlateSound PressedSlateSound;
	///<summary>The sound to play when the button is pressed while selected</summary>
	public FCommonButtonStyleOptionalSlateSound SelectedPressedSlateSound;
	///<summary>The sound to play when the button is pressed while locked</summary>
	public FCommonButtonStyleOptionalSlateSound LockedPressedSlateSound;
	///<summary>The sound to play when the button is hovered</summary>
	public FSlateSound HoveredSlateSound;
	///<summary>The sound to play when the button is hovered while selected</summary>
	public FCommonButtonStyleOptionalSlateSound SelectedHoveredSlateSound;
	///<summary>The sound to play when the button is hovered while locked</summary>
	public FCommonButtonStyleOptionalSlateSound LockedHoveredSlateSound;
	///<summary>GetMaterialBrush</summary>
	public void GetMaterialBrush(FSlateBrush Brush) {}
	///<summary>GetNormalBaseBrush</summary>
	public void GetNormalBaseBrush(FSlateBrush Brush) {}
	///<summary>GetNormalHoveredBrush</summary>
	public void GetNormalHoveredBrush(FSlateBrush Brush) {}
	///<summary>GetNormalPressedBrush</summary>
	public void GetNormalPressedBrush(FSlateBrush Brush) {}
	///<summary>GetSelectedBaseBrush</summary>
	public void GetSelectedBaseBrush(FSlateBrush Brush) {}
	///<summary>GetSelectedHoveredBrush</summary>
	public void GetSelectedHoveredBrush(FSlateBrush Brush) {}
	///<summary>GetSelectedPressedBrush</summary>
	public void GetSelectedPressedBrush(FSlateBrush Brush) {}
	///<summary>GetDisabledBrush</summary>
	public void GetDisabledBrush(FSlateBrush Brush) {}
	///<summary>GetButtonPadding</summary>
	public void GetButtonPadding(FMargin OutButtonPadding) {}
	///<summary>GetCustomPadding</summary>
	public void GetCustomPadding(FMargin OutCustomPadding) {}
	///<summary>GetNormalTextStyle</summary>
	public UCommonTextStyle GetNormalTextStyle() { return default; }
	///<summary>GetNormalHoveredTextStyle</summary>
	public UCommonTextStyle GetNormalHoveredTextStyle() { return default; }
	///<summary>GetSelectedTextStyle</summary>
	public UCommonTextStyle GetSelectedTextStyle() { return default; }
	///<summary>GetSelectedHoveredTextStyle</summary>
	public UCommonTextStyle GetSelectedHoveredTextStyle() { return default; }
	///<summary>GetDisabledTextStyle</summary>
	public UCommonTextStyle GetDisabledTextStyle() { return default; }
}
