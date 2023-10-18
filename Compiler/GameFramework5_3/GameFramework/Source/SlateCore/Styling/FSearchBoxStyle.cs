namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SSearchBox</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FSearchBoxStyle {
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
