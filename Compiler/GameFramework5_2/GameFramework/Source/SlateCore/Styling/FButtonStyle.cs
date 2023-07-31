#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SButton</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FButtonStyle {
	public FSlateBrush Normal;
	public FSlateBrush Hovered;
	public FSlateBrush Pressed;
	public FSlateBrush Disabled;
	public FSlateColor NormalForeground;
	public FSlateColor HoveredForeground;
	public FSlateColor PressedForeground;
	public FSlateColor DisabledForeground;
	public FMargin NormalPadding;
	public FMargin PressedPadding;
	public FSlateSound PressedSlateSound;
	public FSlateSound HoveredSlateSound;
	public string PressedSound_DEPRECATED;
	public string HoveredSound_DEPRECATED;
}
