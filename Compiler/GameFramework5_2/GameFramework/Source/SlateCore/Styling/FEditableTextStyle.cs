#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an SEditableText</summary>
public partial struct FEditableTextStyle {
// EditableTextStyle
	public FSlateFontInfo Font;
	public FSlateColor ColorAndOpacity;
	public FSlateBrush BackgroundImageSelected;
	public FSlateBrush BackgroundImageComposing;
	public FSlateBrush CaretImage;
}
