#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SComboButton</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FComboButtonStyle {
	public FButtonStyle ButtonStyle;
	public FSlateBrush DownArrowImage;
	public FDeprecateSlateVector2D ShadowOffset;
	public FLinearColor ShadowColorAndOpacity;
	public FSlateBrush MenuBorderBrush;
	public FMargin MenuBorderPadding;
	public FMargin ContentPadding;
	public FMargin DownArrowPadding;
	public EVerticalAlignment DownArrowAlign;
}
