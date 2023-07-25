#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an SButton</summary>
public partial struct FButtonStyle {
// ButtonStyle
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
