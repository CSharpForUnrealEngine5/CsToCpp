namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SSegmentedControl</summary>
[CppInclude("Styling/SegmentedControlStyle.h")]
public partial struct FSegmentedControlStyle {
	public FCheckBoxStyle ControlStyle;
	public FCheckBoxStyle FirstControlStyle;
	public FCheckBoxStyle LastControlStyle;
	public FSlateBrush BackgroundBrush;
	public FMargin UniformPadding;
}
