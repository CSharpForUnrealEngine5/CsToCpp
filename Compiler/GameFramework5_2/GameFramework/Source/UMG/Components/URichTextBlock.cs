#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The rich text block</summary>
[CppInclude("Components/RichTextBlock.h")]
public partial class URichTextBlock : UTextLayoutWidget {
	///<summary>The text to display</summary>
	public string Text;
	///<summary>TextStyleSet</summary>
	public UDataTable TextStyleSet;
	///<summary>DecoratorClasses</summary>
	public TArray<UClass> DecoratorClasses;
	///<summary>True to specify the default text style for this rich text inline, overriding any default provided in the style set table</summary>
	public bool bOverrideDefaultStyle;
	///<summary>Text style to apply by default to text in this block</summary>
	public FTextBlockStyle DefaultTextStyleOverride;
	///<summary>The minimum desired size for the text</summary>
	public float MinDesiredWidth;
	///<summary>The text transformation policy to apply to this text block</summary>
	public ETextTransformPolicy TextTransformPolicy;
	///<summary>Sets what happens to text that is clipped and doesn&#39;t fit within the clip rect for this widget</summary>
	public ETextOverflowPolicy TextOverflowPolicy;
	///<summary>Sets the color and opacity of the default text in this rich text block</summary>
	public  void SetDefaultColorAndOpacity(FSlateColor InColorAndOpacity) {}
	///<summary>Sets the color and opacity of the default text drop shadow</summary>
	public  void SetDefaultShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity) {}
	///<summary>Sets the offset that the default text drop shadow should be drawn at</summary>
	public  void SetDefaultShadowOffset(FVector2D InShadowOffset) {}
	///<summary>Dynamically set the default font info for this rich text block</summary>
	public  void SetDefaultFont(FSlateFontInfo InFontInfo) {}
	///<summary>Dynamically set the default strike brush for this rich text block</summary>
	public  void SetDefaultStrikeBrush(FSlateBrush InStrikeBrush) {}
	///<summary>Set the minimum desired width for this rich text block</summary>
	public  void SetMinDesiredWidth(float InMinDesiredWidth) {}
	///<summary>Set the auto wrap for this rich text block</summary>
	public  void SetAutoWrapText(bool InAutoTextWrap) {}
	///<summary>Set the text transformation policy for this text block.</summary>
	public  void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy) {}
	///<summary>Set the text overflow policy for this text block.</summary>
	public  void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) {}
	///<summary>Wholesale override of the currently established default text style</summary>
	public  void SetDefaultTextStyle(FTextBlockStyle InDefaultTextStyle) {}
	///<summary>SetDefaultMaterial</summary>
	public  void SetDefaultMaterial(UMaterialInterface InMaterial) {}
	///<summary>Remove all overrides made to the default text style and return to the style specified in the style set data table</summary>
	public  void ClearAllDefaultStyleOverrides() {}
	///<summary>Creates a dynamic material for the default font or returns it if it already</summary>
	public  UMaterialInstanceDynamic GetDefaultDynamicMaterial() { return default; }
	///<summary>Replaces the existing decorators with the list provided</summary>
	public  void SetDecorators(TArray<UClass> InDecoratorClasses) {}
	///<summary>Returns widgets text.</summary>
	public  string GetText() { return default; }
	///<summary>Directly sets the widget text.</summary>
	public  void SetText(string InText) {}
	///<summary>GetTextStyleSet</summary>
	public  UDataTable GetTextStyleSet() { return default; }
	///<summary>SetTextStyleSet</summary>
	public  void SetTextStyleSet(UDataTable NewTextStyleSet) {}
	///<summary>GetDecoratorByClass</summary>
	public  URichTextBlockDecorator GetDecoratorByClass(UClass DecoratorClass) { return default; }
	///<summary>Causes the text to reflow it&#39;s layout and re-evaluate any decorators</summary>
	public  void RefreshTextLayout() {}
	///<summary>DefaultTextStyle</summary>
	public FTextBlockStyle DefaultTextStyle;
	///<summary>InstanceDecorators</summary>
	public TArray<URichTextBlockDecorator> InstanceDecorators;
}
