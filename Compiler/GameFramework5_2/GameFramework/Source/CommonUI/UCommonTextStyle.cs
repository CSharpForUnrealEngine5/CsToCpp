#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonTextBlock.h")]
///<summary>* ---- All properties must be EditDefaultsOnly, BlueprintReadOnly !!! -----</summary>
public partial class UCommonTextStyle : UObject {
// CommonTextStyle
	public FSlateFontInfo Font;
	public FLinearColor Color;
	public bool bUsesDropShadow;
	public FVector2D ShadowOffset;
	public FLinearColor ShadowColor;
	public FMargin Margin;
	public FSlateBrush StrikeBrush;
	public float LineHeightPercentage;
	public void GetFont(FSlateFontInfo OutFont) {}
	public void GetColor(FLinearColor OutColor) {}
	public void GetMargin(FMargin OutMargin) {}
	public float GetLineHeightPercentage() { return default; }
	public void GetShadowOffset(FVector2D OutShadowOffset) {}
	public void GetShadowColor(FLinearColor OutColor) {}
	public void GetStrikeBrush(FSlateBrush OutStrikeBrush) {}
}
