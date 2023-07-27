#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonRichTextBlock.h")]
///<summary>Text block that supports custom scaling for mobile platforms, with option to only show icons if space is sparse.</summary>
public partial class UCommonRichTextBlock : URichTextBlock {
// CommonRichTextBlock
	public  void SetScrollingEnabled(bool bInIsScrollingEnabled) {}
	public ERichTextInlineIconDisplayMode InlineIconDisplayMode;
	public bool bTintInlineIcon;
	public UClass DefaultTextStyleOverrideClass;
	public float MobileTextBlockScale;
	public UClass ScrollStyle;
	public bool bIsScrollingEnabled;
	public bool bDisplayAllCaps_DEPRECATED;
	public bool bAutoCollapseWithEmptyText;
}
