#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an SComboButton</summary>
public partial struct FComboButtonStyle {
// ComboButtonStyle
	public FButtonStyle ButtonStyle;
	public FSlateBrush DownArrowImage;
	public FDeprecateSlateVector2D ShadowOffset;
	public FLinearColor ShadowColorAndOpacity;
	public FSlateBrush MenuBorderBrush;
	public FMargin MenuBorderPadding;
	public FMargin ContentPadding;
	public FMargin DownArrowPadding;
	public byte DownArrowAlign;
}
