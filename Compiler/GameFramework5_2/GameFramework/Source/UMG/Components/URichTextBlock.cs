#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/RichTextBlock.h")]
///<summary>The rich text block</summary>
public partial class URichTextBlock : UTextLayoutWidget {
// RichTextBlock
	public string Text;
	public UDataTable TextStyleSet;
	public TArray<UClass> DecoratorClasses;
	public bool bOverrideDefaultStyle;
	public FTextBlockStyle DefaultTextStyleOverride;
	public float MinDesiredWidth;
	public ETextTransformPolicy TextTransformPolicy;
	public ETextOverflowPolicy TextOverflowPolicy;
	public void SetDefaultColorAndOpacity(FSlateColor InColorAndOpacity) {}
	public void SetDefaultShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity) {}
	public void SetDefaultShadowOffset(FVector2D InShadowOffset) {}
	public void SetDefaultFont(FSlateFontInfo InFontInfo) {}
	public void SetDefaultStrikeBrush(FSlateBrush InStrikeBrush) {}
	public void SetMinDesiredWidth(float InMinDesiredWidth) {}
	public void SetAutoWrapText(bool InAutoTextWrap) {}
	public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy) {}
	public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) {}
	public void SetDefaultTextStyle(FTextBlockStyle InDefaultTextStyle) {}
	public void SetDefaultMaterial(UObject InMaterial) {}
	public void ClearAllDefaultStyleOverrides() {}
	public UObject GetDefaultDynamicMaterial() { return default; }
	public void SetDecorators(TArray<UClass> InDecoratorClasses) {}
	public string GetText() { return default; }
	public void SetText(string InText) {}
	public UObject GetTextStyleSet() { return default; }
	public void SetTextStyleSet(UObject NewTextStyleSet) {}
	public UObject GetDecoratorByClass(UClass DecoratorClass) { return default; }
	public void RefreshTextLayout() {}
	public FTextBlockStyle DefaultTextStyle;
	public TArray<URichTextBlockDecorator> InstanceDecorators;
}
