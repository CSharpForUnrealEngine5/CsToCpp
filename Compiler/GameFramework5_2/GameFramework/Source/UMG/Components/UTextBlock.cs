#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TextBlock.h")]
///<summary>A simple static text widget.</summary>
public partial class UTextBlock : UTextLayoutWidget {
// TextBlock
	public string Text;
	public FGetText TextDelegate;
	public FSlateColor ColorAndOpacity;
	public FGetSlateColor ColorAndOpacityDelegate;
	public FSlateFontInfo Font;
	public FSlateBrush StrikeBrush;
	public FVector2D ShadowOffset;
	public FLinearColor ShadowColorAndOpacity;
	public FGetLinearColor ShadowColorAndOpacityDelegate;
	public float MinDesiredWidth;
	public bool bWrapWithInvalidationPanel;
	public ETextTransformPolicy TextTransformPolicy;
	public ETextOverflowPolicy TextOverflowPolicy;
	public string GetText() { return default; }
	public void SetText(string InText) {}
	public void SetColorAndOpacity(FSlateColor InColorAndOpacity) {}
	public void SetOpacity(float InOpacity) {}
	public void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity) {}
	public void SetShadowOffset(FVector2D InShadowOffset) {}
	public void SetFont(FSlateFontInfo InFontInfo) {}
	public void SetStrikeBrush(FSlateBrush InStrikeBrush) {}
	public void SetMinDesiredWidth(float InMinDesiredWidth) {}
	public void SetAutoWrapText(bool InAutoTextWrap) {}
	public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy) {}
	public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) {}
	public void SetFontMaterial(UObject InMaterial) {}
	public void SetFontOutlineMaterial(UObject InMaterial) {}
	public UObject GetDynamicFontMaterial() { return default; }
	public UObject GetDynamicOutlineMaterial() { return default; }
	public bool bSimpleTextMode;
}
