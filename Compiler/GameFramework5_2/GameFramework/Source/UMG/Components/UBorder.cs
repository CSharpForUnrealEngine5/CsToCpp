#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Border.h")]
///<summary>A border is a container widget that can contain one child widget, providing an opportunity</summary>
public partial class UBorder : UContentWidget {
// Border
	public EHorizontalAlignment HorizontalAlignment;
	public EVerticalAlignment VerticalAlignment;
	public bool bShowEffectWhenDisabled;
	public FLinearColor ContentColorAndOpacity;
	public FGetLinearColor ContentColorAndOpacityDelegate;
	public FMargin Padding;
	public FSlateBrush Background;
	public FGetSlateBrush BackgroundDelegate;
	public FLinearColor BrushColor;
	public FGetLinearColor BrushColorDelegate;
	public FVector2D DesiredSizeScale;
	public bool bFlipForRightToLeftFlowDirection;
	public FOnPointerEvent OnMouseButtonDownEvent;
	public FOnPointerEvent OnMouseButtonUpEvent;
	public FOnPointerEvent OnMouseMoveEvent;
	public FOnPointerEvent OnMouseDoubleClickEvent;
	public  void SetContentColorAndOpacity(FLinearColor InContentColorAndOpacity) {}
	public  void SetPadding(FMargin InPadding) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	public  void SetBrushColor(FLinearColor InBrushColor) {}
	public  void SetBrush(FSlateBrush InBrush) {}
	public  void SetBrushFromAsset(USlateBrushAsset Asset) {}
	public  void SetBrushFromTexture(UTexture2D Texture) {}
	public  void SetBrushFromMaterial(UMaterialInterface Material) {}
	public  void SetShowEffectWhenDisabled(bool bInShowEffectWhenDisabled) {}
	public  UMaterialInstanceDynamic GetDynamicMaterial() { return default; }
	public  void SetDesiredSizeScale(FVector2D InScale) {}
}
