namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SEditableTextBox</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FEditableTextBoxStyle {
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
