#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an SEditableTextBox</summary>
public partial struct FEditableTextBoxStyle {
// EditableTextBoxStyle
	public FSlateBrush BackgroundImageNormal;
	public FSlateBrush BackgroundImageHovered;
	public FSlateBrush BackgroundImageFocused;
	public FSlateBrush BackgroundImageReadOnly;
	public FMargin Padding;
	public FSlateFontInfo Font_DEPRECATED;
	public FTextBlockStyle TextStyle;
	public FSlateColor ForegroundColor;
	public FSlateColor BackgroundColor;
	public FSlateColor ReadOnlyForegroundColor;
	public FSlateColor FocusedForegroundColor;
	public FMargin HScrollBarPadding;
	public FMargin VScrollBarPadding;
	public FScrollBarStyle ScrollBarStyle;
}
