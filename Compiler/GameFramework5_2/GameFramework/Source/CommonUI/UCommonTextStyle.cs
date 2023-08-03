#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* ---- All properties must be EditDefaultsOnly, BlueprintReadOnly !!! -----</summary>
[CppInclude("CommonTextBlock.h")]
public partial class UCommonTextStyle : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The font to apply at each size</summary>
	public FSlateFontInfo Font;
	///<summary>The color of the text</summary>
	public FLinearColor Color;
	///<summary>Whether or not the style uses a drop shadow</summary>
	public bool bUsesDropShadow;
	///<summary>The offset of the drop shadow at each size</summary>
	public FVector2D ShadowOffset;
	///<summary>The drop shadow color</summary>
	public FLinearColor ShadowColor;
	///<summary>The amount of blank space left around the edges of text area at each size</summary>
	public FMargin Margin;
	///<summary>The brush used to draw an strike through the text (if any)</summary>
	public FSlateBrush StrikeBrush;
	///<summary>The amount to scale each lines height by at each size</summary>
	public float LineHeightPercentage;
	///<summary>GetFont</summary>
	public  void GetFont(FSlateFontInfo OutFont) {}
	///<summary>GetColor</summary>
	public  void GetColor(FLinearColor OutColor) {}
	///<summary>GetMargin</summary>
	public  void GetMargin(FMargin OutMargin) {}
	///<summary>GetLineHeightPercentage</summary>
	public  float GetLineHeightPercentage() { return default; }
	///<summary>GetShadowOffset</summary>
	public  void GetShadowOffset(FVector2D OutShadowOffset) {}
	///<summary>GetShadowColor</summary>
	public  void GetShadowColor(FLinearColor OutColor) {}
	///<summary>GetStrikeBrush</summary>
	public  void GetStrikeBrush(FSlateBrush OutStrikeBrush) {}
}
