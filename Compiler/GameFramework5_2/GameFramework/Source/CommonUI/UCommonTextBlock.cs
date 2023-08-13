namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Text block with automatic scrolling for FX / large texts, also supports a larger set of default styling, &amp; custom mobile scaling.</summary>
[CppInclude("CommonTextBlock.h")]
public partial class UCommonTextBlock : UTextBlock {
	public static UClass StaticClass() {return default;}
	///<summary>SetWrapTextWidth</summary>
	public void SetWrapTextWidth(int InWrapTextAt) {}
	///<summary>SetTextCase</summary>
	public void SetTextCase(bool bUseAllCaps) {}
	///<summary>SetLineHeightPercentage</summary>
	public void SetLineHeightPercentage(float InLineHeightPercentage) {}
	///<summary>SetStyle</summary>
	public void SetStyle(UClass InStyle) {}
	///<summary>GetMargin</summary>
	public FMargin GetMargin() { return default; }
	///<summary>SetMargin</summary>
	public void SetMargin(FMargin InMargin) {}
	///<summary>GetMobileFontSizeMultiplier</summary>
	public float GetMobileFontSizeMultiplier() { return default; }
	///<summary>Sets the new value and then applies the FontSizeMultiplier</summary>
	public void SetMobileFontSizeMultiplier(float InMobileFontSizeMultiplier) {}
	///<summary>ResetScrollState</summary>
	public void ResetScrollState() {}
	///<summary>SetScrollingEnabled</summary>
	public void SetScrollingEnabled(bool bInIsScrollingEnabled) {}
	///<summary>Mobile font size multiplier. Activated by default on mobile. See CVar Mobile_PreviewFontSize</summary>
	public float MobileFontSizeMultiplier;
	///<summary>References the text style to use</summary>
	public UClass Style;
	///<summary>References the scroll style asset to use, no reference disables scrolling</summary>
	public UClass ScrollStyle;
	///<summary>Prototype: Do not use!</summary>
	public UCommonStyleSheet StyleSheet;
	///<summary>If scrolling is enabled/disabled initially, this can be updated in blueprint</summary>
	public bool bIsScrollingEnabled;
	///<summary>True to always display text in ALL CAPS</summary>
	public bool bDisplayAllCaps_DEPRECATED;
	///<summary>True to automatically collapse this text block when set to display an empty string. Conversely, will be SelfHitTestInvisible when showing a non-empty string.</summary>
	public bool bAutoCollapseWithEmptyText;
	///<summary>Used to track widgets that were created before changing the default style pointer to null</summary>
	public bool bStyleNoLongerNeedsConversion;
}
