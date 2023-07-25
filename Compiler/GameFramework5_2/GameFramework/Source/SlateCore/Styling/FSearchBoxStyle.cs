#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an SSearchBox</summary>
public partial struct FSearchBoxStyle {
// SearchBoxStyle
	public FEditableTextBoxStyle TextBoxStyle;
	public FSlateFontInfo ActiveFontInfo;
	public FSlateBrush UpArrowImage;
	public FSlateBrush DownArrowImage;
	public FSlateBrush GlassImage;
	public FSlateBrush ClearImage;
	public FMargin ImagePadding;
	public bool bLeftAlignButtons_DEPRECATED;
	public bool bLeftAlignSearchResultButtons;
	public bool bLeftAlignGlassImageAndClearButton;
}
