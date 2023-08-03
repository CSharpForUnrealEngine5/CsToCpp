#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A border is a container widget that can contain one child widget, providing an opportunity</summary>
[CppInclude("Components/Border.h")]
public partial class UBorder : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The alignment of the content horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the content vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>Whether or not to show the disabled effect when this border is disabled</summary>
	public bool bShowEffectWhenDisabled;
	///<summary>Color and opacity multiplier of content in the border</summary>
	public FLinearColor ContentColorAndOpacity;
	///<summary>A bindable delegate for the ContentColorAndOpacity.</summary>
	public FGetLinearColor ContentColorAndOpacityDelegate;
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>Brush to drag as the background</summary>
	public FSlateBrush Background;
	///<summary>A bindable delegate for the Brush.</summary>
	public FGetSlateBrush BackgroundDelegate;
	///<summary>Color and opacity of the actual border image</summary>
	public FLinearColor BrushColor;
	///<summary>A bindable delegate for the BrushColor.</summary>
	public FGetLinearColor BrushColorDelegate;
	///<summary>Scales the computed desired size of this border and its contents. Useful</summary>
	public FVector2D DesiredSizeScale;
	///<summary>Flips the background image if the localization&#39;s flow direction is RightToLeft</summary>
	public bool bFlipForRightToLeftFlowDirection;
	///<summary>OnMouseButtonDownEvent</summary>
	public FOnPointerEvent OnMouseButtonDownEvent;
	///<summary>OnMouseButtonUpEvent</summary>
	public FOnPointerEvent OnMouseButtonUpEvent;
	///<summary>OnMouseMoveEvent</summary>
	public FOnPointerEvent OnMouseMoveEvent;
	///<summary>OnMouseDoubleClickEvent</summary>
	public FOnPointerEvent OnMouseDoubleClickEvent;
	///<summary>SetContentColorAndOpacity</summary>
	public  void SetContentColorAndOpacity(FLinearColor InContentColorAndOpacity) {}
	///<summary>SetPadding</summary>
	public  void SetPadding(FMargin InPadding) {}
	///<summary>SetHorizontalAlignment</summary>
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	///<summary>SetBrushColor</summary>
	public  void SetBrushColor(FLinearColor InBrushColor) {}
	///<summary>SetBrush</summary>
	public  void SetBrush(FSlateBrush InBrush) {}
	///<summary>SetBrushFromAsset</summary>
	public  void SetBrushFromAsset(USlateBrushAsset Asset) {}
	///<summary>SetBrushFromTexture</summary>
	public  void SetBrushFromTexture(UTexture2D Texture) {}
	///<summary>SetBrushFromMaterial</summary>
	public  void SetBrushFromMaterial(UMaterialInterface Material) {}
	///<summary>SetShowEffectWhenDisabled</summary>
	public  void SetShowEffectWhenDisabled(bool bInShowEffectWhenDisabled) {}
	///<summary>GetDynamicMaterial</summary>
	public  UMaterialInstanceDynamic GetDynamicMaterial() { return default; }
	///<summary>Sets the DesiredSizeScale of this border.</summary>
	public  void SetDesiredSizeScale(FVector2D InScale) {}
}
