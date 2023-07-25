#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Image.h")]
///<summary>The image widget allows you to display a Slate Brush, or texture or material in the UI.</summary>
public partial class UImage : UWidget {
// Image
	public FSlateBrush Brush;
	public FGetSlateBrush BrushDelegate;
	public FLinearColor ColorAndOpacity;
	public FGetLinearColor ColorAndOpacityDelegate;
	public bool bFlipForRightToLeftFlowDirection;
	public FOnPointerEvent OnMouseButtonDownEvent;
	public void SetColorAndOpacity(FLinearColor InColorAndOpacity) {}
	public void SetOpacity(float InOpacity) {}
	public void SetDesiredSizeOverride(FVector2D DesiredSize) {}
	public void SetBrushTintColor(FSlateColor TintColor) {}
	public void SetBrushResourceObject(UObject ResourceObject) {}
	public void SetBrush(FSlateBrush InBrush) {}
	public void SetBrushFromAsset(UObject Asset) {}
	public void SetBrushFromTexture(UObject Texture,bool bMatchSize/*=false*/) {}
	public void SetBrushFromAtlasInterface(object /*AtlasRegion*/ AtlasRegion,bool bMatchSize/*=false*/) {}
	public void SetBrushFromTextureDynamic(UObject Texture,bool bMatchSize/*=false*/) {}
	public void SetBrushFromMaterial(UObject Material) {}
	public void SetBrushFromSoftTexture(TSoftObjectPtr<UTexture2D> SoftTexture,bool bMatchSize/*=false*/) {}
	public void SetBrushFromSoftMaterial(TSoftObjectPtr<UMaterialInterface> SoftMaterial) {}
	public UObject GetDynamicMaterial() { return default; }
}
