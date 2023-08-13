namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SScrollBox</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FScrollBoxStyle {
	public float BarThickness;
	public FSlateBrush TopShadowBrush;
	public FSlateBrush BottomShadowBrush;
	public FSlateBrush LeftShadowBrush;
	public FSlateBrush RightShadowBrush;
	public FMargin HorizontalScrolledContentPadding;
	public FMargin VerticalScrolledContentPadding;
}
