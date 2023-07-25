#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateColor.h")]
///<summary>A Slate color can be a directly specified value, or the color can be pulled from a WidgetStyle.</summary>
public partial struct FSlateColor {
// SlateColor
	public FLinearColor SpecifiedColor;
	public ESlateColorStylingMode ColorUseRule;
}
