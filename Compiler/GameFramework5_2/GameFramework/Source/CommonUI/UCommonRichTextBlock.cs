#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Text block that supports custom scaling for mobile platforms, with option to only show icons if space is sparse.</summary>
[CppInclude("CommonRichTextBlock.h")]
public partial class UCommonRichTextBlock : URichTextBlock {
	public static UClass StaticClass() {return default;}
	///<summary>SetScrollingEnabled</summary>
	public  void SetScrollingEnabled(bool bInIsScrollingEnabled) {}
	///<summary>InlineIconDisplayMode</summary>
	public ERichTextInlineIconDisplayMode InlineIconDisplayMode;
	///<summary>Toggle it on if the text color should also tint the inline icons.</summary>
	public bool bTintInlineIcon;
	///<summary>DefaultTextStyleOverrideClass</summary>
	public UClass DefaultTextStyleOverrideClass;
	///<summary>Mobile font size multiplier. Activated by default on mobile. See CVar Mobile_PreviewFontSize</summary>
	public float MobileTextBlockScale;
	///<summary>References the scroll style asset to use, no reference disables scrolling</summary>
	public UClass ScrollStyle;
	///<summary>If scrolling is enabled/disabled initially, this can be updated in blueprint</summary>
	public bool bIsScrollingEnabled;
	///<summary>True to always display text in ALL CAPS</summary>
	public bool bDisplayAllCaps_DEPRECATED;
	///<summary>True to automatically collapse this rich text block when set to display an empty string. Conversely, will be SelfHitTestInvisible when showing a non-empty string.</summary>
	public bool bAutoCollapseWithEmptyText;
}
