#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SVolumeControl</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FVolumeControlStyle {
	public FSliderStyle SliderStyle;
	public FSlateBrush HighVolumeImage;
	public FSlateBrush MidVolumeImage;
	public FSlateBrush LowVolumeImage;
	public FSlateBrush NoVolumeImage;
	public FSlateBrush MutedImage;
}
