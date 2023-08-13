namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an STableColumnHeader</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FTableColumnHeaderStyle {
	public FSlateBrush SortPrimaryAscendingImage;
	public FSlateBrush SortPrimaryDescendingImage;
	public FSlateBrush SortSecondaryAscendingImage;
	public FSlateBrush SortSecondaryDescendingImage;
	public FSlateBrush NormalBrush;
	public FSlateBrush HoveredBrush;
	public FSlateBrush MenuDropdownImage;
	public FSlateBrush MenuDropdownNormalBorderBrush;
	public FSlateBrush MenuDropdownHoveredBorderBrush;
}
