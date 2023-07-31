#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The image widget allows you to display a Slate Brush, or texture or material in the UI.</summary>
[CppInclude("Components/Image.h")]
public partial class UImage : UWidget {
	///<summary>Image to draw</summary>
	public FSlateBrush Brush;
	///<summary>A bindable delegate for the Image.</summary>
	public FGetSlateBrush BrushDelegate;
	///<summary>Color and opacity</summary>
	public FLinearColor ColorAndOpacity;
	///<summary>A bindable delegate for the ColorAndOpacity.</summary>
	public FGetLinearColor ColorAndOpacityDelegate;
	///<summary>Flips the image if the localization&#39;s flow direction is RightToLeft</summary>
	public bool bFlipForRightToLeftFlowDirection;
	///<summary>OnMouseButtonDownEvent</summary>
	public FOnPointerEvent OnMouseButtonDownEvent;
	///<summary>SetColorAndOpacity</summary>
	public  void SetColorAndOpacity(FLinearColor InColorAndOpacity) {}
	///<summary>SetOpacity</summary>
	public  void SetOpacity(float InOpacity) {}
	///<summary>SetDesiredSizeOverride</summary>
	public  void SetDesiredSizeOverride(FVector2D DesiredSize) {}
	///<summary>SetBrushTintColor</summary>
	public  void SetBrushTintColor(FSlateColor TintColor) {}
	///<summary>SetBrushResourceObject</summary>
	public  void SetBrushResourceObject(UObject ResourceObject) {}
	///<summary>SetBrush</summary>
	public  void SetBrush(FSlateBrush InBrush) {}
	///<summary>SetBrushFromAsset</summary>
	public  void SetBrushFromAsset(USlateBrushAsset Asset) {}
	///<summary>Sets the Brush to the specified Texture.</summary>
	public  void SetBrushFromTexture(UTexture2D Texture,bool bMatchSize/*=false*/) {}
	///<summary>Sets the Brush to the specified Atlas Region.</summary>
	public  void SetBrushFromAtlasInterface(object /*AtlasRegion*/ AtlasRegion,bool bMatchSize/*=false*/) {}
	///<summary>Sets the Brush to the specified Dynamic Texture.</summary>
	public  void SetBrushFromTextureDynamic(UTexture2DDynamic Texture,bool bMatchSize/*=false*/) {}
	///<summary>SetBrushFromMaterial</summary>
	public  void SetBrushFromMaterial(UMaterialInterface Material) {}
	///<summary>Sets the Brush to the specified Soft Texture.</summary>
	public  void SetBrushFromSoftTexture(TSoftObjectPtr<UTexture2D> SoftTexture,bool bMatchSize/*=false*/) {}
	///<summary>SetBrushFromSoftMaterial</summary>
	public  void SetBrushFromSoftMaterial(TSoftObjectPtr<UMaterialInterface> SoftMaterial) {}
	///<summary>GetDynamicMaterial</summary>
	public  UMaterialInstanceDynamic GetDynamicMaterial() { return default; }
}
