namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SScrollBar</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FScrollBarStyle {
	public FSlateBrush HorizontalBackgroundImage;
	public FSlateBrush VerticalBackgroundImage;
	public FSlateBrush VerticalTopSlotImage;
	public FSlateBrush HorizontalTopSlotImage;
	public FSlateBrush VerticalBottomSlotImage;
	public FSlateBrush HorizontalBottomSlotImage;
	public FSlateBrush NormalThumbImage;
	public FSlateBrush HoveredThumbImage;
	public FSlateBrush DraggedThumbImage;
	public float Thickness;
}
