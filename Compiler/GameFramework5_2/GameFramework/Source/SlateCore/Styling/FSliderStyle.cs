#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SSlider</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FSliderStyle {
	public FSlateBrush NormalBarImage;
	public FSlateBrush HoveredBarImage;
	public FSlateBrush DisabledBarImage;
	public FSlateBrush NormalThumbImage;
	public FSlateBrush HoveredThumbImage;
	public FSlateBrush DisabledThumbImage;
	public float BarThickness;
}
