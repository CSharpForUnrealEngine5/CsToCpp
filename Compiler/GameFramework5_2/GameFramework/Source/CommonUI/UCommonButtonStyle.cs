#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonButtonBase.h")]
///<summary>---- All properties must be EditDefaultsOnly, BlueprintReadOnly !!! -----</summary>
public partial class UCommonButtonStyle : UObject {
// CommonButtonStyle
	public bool bSingleMaterial;
	public FSlateBrush SingleMaterialBrush;
	public FSlateBrush NormalBase;
	public FSlateBrush NormalHovered;
	public FSlateBrush NormalPressed;
	public FSlateBrush SelectedBase;
	public FSlateBrush SelectedHovered;
	public FSlateBrush SelectedPressed;
	public FSlateBrush Disabled;
	public FMargin ButtonPadding;
	public FMargin CustomPadding;
	public int MinWidth;
	public int MinHeight;
	public UClass NormalTextStyle;
	public UClass NormalHoveredTextStyle;
	public UClass SelectedTextStyle;
	public UClass SelectedHoveredTextStyle;
	public UClass DisabledTextStyle;
	public FSlateSound PressedSlateSound;
	public FCommonButtonStyleOptionalSlateSound SelectedPressedSlateSound;
	public FCommonButtonStyleOptionalSlateSound LockedPressedSlateSound;
	public FSlateSound HoveredSlateSound;
	public FCommonButtonStyleOptionalSlateSound SelectedHoveredSlateSound;
	public FCommonButtonStyleOptionalSlateSound LockedHoveredSlateSound;
	public  void GetMaterialBrush(FSlateBrush Brush) {}
	public  void GetNormalBaseBrush(FSlateBrush Brush) {}
	public  void GetNormalHoveredBrush(FSlateBrush Brush) {}
	public  void GetNormalPressedBrush(FSlateBrush Brush) {}
	public  void GetSelectedBaseBrush(FSlateBrush Brush) {}
	public  void GetSelectedHoveredBrush(FSlateBrush Brush) {}
	public  void GetSelectedPressedBrush(FSlateBrush Brush) {}
	public  void GetDisabledBrush(FSlateBrush Brush) {}
	public  void GetButtonPadding(FMargin OutButtonPadding) {}
	public  void GetCustomPadding(FMargin OutCustomPadding) {}
	public  UCommonTextStyle GetNormalTextStyle() { return default; }
	public  UCommonTextStyle GetNormalHoveredTextStyle() { return default; }
	public  UCommonTextStyle GetSelectedTextStyle() { return default; }
	public  UCommonTextStyle GetSelectedHoveredTextStyle() { return default; }
	public  UCommonTextStyle GetDisabledTextStyle() { return default; }
}
