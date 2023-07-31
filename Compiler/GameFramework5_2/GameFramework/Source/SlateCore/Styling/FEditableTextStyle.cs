#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SEditableText</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FEditableTextStyle {
	public FSlateFontInfo Font;
	public FSlateColor ColorAndOpacity;
	public FSlateBrush BackgroundImageSelected;
	public FSlateBrush BackgroundImageComposing;
	public FSlateBrush CaretImage;
}
