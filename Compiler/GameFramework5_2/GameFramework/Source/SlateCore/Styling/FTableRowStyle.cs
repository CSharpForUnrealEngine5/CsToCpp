#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an STableRow</summary>
public partial struct FTableRowStyle {
// TableRowStyle
	public FSlateBrush SelectorFocusedBrush;
	public FSlateBrush ActiveHoveredBrush;
	public FSlateBrush ActiveBrush;
	public FSlateBrush InactiveHoveredBrush;
	public FSlateBrush InactiveBrush;
	public bool bUseParentRowBrush;
	public FSlateBrush ParentRowBackgroundBrush;
	public FSlateBrush ParentRowBackgroundHoveredBrush;
	public FSlateBrush EvenRowBackgroundHoveredBrush;
	public FSlateBrush EvenRowBackgroundBrush;
	public FSlateBrush OddRowBackgroundHoveredBrush;
	public FSlateBrush OddRowBackgroundBrush;
	public FSlateColor TextColor;
	public FSlateColor SelectedTextColor;
	public FSlateBrush DropIndicator_Above;
	public FSlateBrush DropIndicator_Onto;
	public FSlateBrush DropIndicator_Below;
	public FSlateBrush ActiveHighlightedBrush;
	public FSlateBrush InactiveHighlightedBrush;
}
