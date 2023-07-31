#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Slate color can be a directly specified value, or the color can be pulled from a WidgetStyle.</summary>
[CppInclude("Styling/SlateColor.h")]
public partial struct FSlateColor {
	public FLinearColor SpecifiedColor;
	public ESlateColorStylingMode ColorUseRule;
}
