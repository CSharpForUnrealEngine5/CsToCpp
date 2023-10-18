namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple static text widget.</summary>
[CppInclude("Components/TextBlock.h")]
public partial class UTextBlock : UTextLayoutWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The text to display</summary>
	public FText Text;
	///<summary>A bindable delegate to allow logic to drive the text of the widget</summary>
	public FGetText TextDelegate;
	///<summary>The color of the text</summary>
	public FSlateColor ColorAndOpacity;
	///<summary>A bindable delegate for the ColorAndOpacity.</summary>
	public FGetSlateColor ColorAndOpacityDelegate;
	///<summary>The font to render the text with</summary>
	public FSlateFontInfo Font;
	///<summary>The brush to strike through text with</summary>
	public FSlateBrush StrikeBrush;
	///<summary>The direction the shadow is cast</summary>
	public FVector2D ShadowOffset;
	///<summary>The color of the shadow</summary>
	public FLinearColor ShadowColorAndOpacity;
	///<summary>A bindable delegate for the ShadowColorAndOpacity.</summary>
	public FGetLinearColor ShadowColorAndOpacityDelegate;
	///<summary>The minimum desired size for the text</summary>
	public float MinDesiredWidth;
	///<summary>If true, it will automatically wrap this text widget with an invalidation panel</summary>
	public bool bWrapWithInvalidationPanel;
	///<summary>The text transformation policy to apply to this text block.</summary>
	public ETextTransformPolicy TextTransformPolicy;
	///<summary>Sets what happens to text that is clipped and doesn&#39;t fit within the clip rect for this widget</summary>
	public ETextOverflowPolicy TextOverflowPolicy;
	///<summary>Gets the widget text</summary>
	public FText GetText() { return default; }
	///<summary>Directly sets the widget text.</summary>
	public virtual void SetText(FText InText) {}
	///<summary>Sets the color and opacity of the text in this text block</summary>
	public void SetColorAndOpacity(FSlateColor InColorAndOpacity) {}
	///<summary>Sets the opacity of the text in this text block</summary>
	public void SetOpacity(float InOpacity) {}
	///<summary>Sets the color and opacity of the text drop shadow</summary>
	public void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity) {}
	///<summary>Sets the offset that the text drop shadow should be drawn at</summary>
	public void SetShadowOffset(FVector2D InShadowOffset) {}
	///<summary>Dynamically set the font info for this text block</summary>
	public void SetFont(FSlateFontInfo InFontInfo) {}
	///<summary>Dynamically set the strike brush for this text block</summary>
	public void SetStrikeBrush(FSlateBrush InStrikeBrush) {}
	///<summary>Set the minimum desired width for this text block</summary>
	public void SetMinDesiredWidth(float InMinDesiredWidth) {}
	///<summary>Set the auto wrap for this text block.</summary>
	public void SetAutoWrapText(bool InAutoTextWrap) {}
	///<summary>Set the text transformation policy for this text block.</summary>
	public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy) {}
	///<summary>Set the text overflow policy for this text block.</summary>
	public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) {}
	///<summary>SetFontMaterial</summary>
	public void SetFontMaterial(UMaterialInterface InMaterial) {}
	///<summary>SetFontOutlineMaterial</summary>
	public void SetFontOutlineMaterial(UMaterialInterface InMaterial) {}
	///<summary>GetDynamicFontMaterial</summary>
	public UMaterialInstanceDynamic GetDynamicFontMaterial() { return default; }
	///<summary>GetDynamicOutlineMaterial</summary>
	public UMaterialInstanceDynamic GetDynamicOutlineMaterial() { return default; }
	///<summary>If this is enabled, text shaping, wrapping, justification are disabled in favor of much faster text layout and measurement.</summary>
	public bool bSimpleTextMode;
}
