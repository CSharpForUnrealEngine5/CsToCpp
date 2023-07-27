#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonTextBlock.h")]
///<summary>Text block with automatic scrolling for FX / large texts, also supports a larger set of default styling, & custom mobile scaling.</summary>
public partial class UCommonTextBlock : UTextBlock {
// CommonTextBlock
	public  void SetWrapTextWidth(int InWrapTextAt) {}
	public  void SetTextCase(bool bUseAllCaps) {}
	public  void SetLineHeightPercentage(float InLineHeightPercentage) {}
	public  void SetStyle(UClass InStyle) {}
	public  FMargin GetMargin() { return default; }
	public  void SetMargin(FMargin InMargin) {}
	public  float GetMobileFontSizeMultiplier() { return default; }
	public  void SetMobileFontSizeMultiplier(float InMobileFontSizeMultiplier) {}
	public  void ResetScrollState() {}
	public  void SetScrollingEnabled(bool bInIsScrollingEnabled) {}
	public float MobileFontSizeMultiplier;
	public UClass Style;
	public UClass ScrollStyle;
	public UCommonStyleSheet StyleSheet;
	public bool bIsScrollingEnabled;
	public bool bDisplayAllCaps_DEPRECATED;
	public bool bAutoCollapseWithEmptyText;
	public bool bStyleNoLongerNeedsConversion;
}
