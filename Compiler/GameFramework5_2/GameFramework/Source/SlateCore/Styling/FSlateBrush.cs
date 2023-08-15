namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A brush which contains information about how to draw a Slate element</summary>
[CppInclude("Styling/SlateBrush.h")]
public partial struct FSlateBrush {
	public bool bIsDynamicallyLoaded;
	public bool bHasUObject_DEPRECATED;
	public ESlateBrushDrawType DrawAs;
	public ESlateBrushTileType Tiling;
	public ESlateBrushMirrorType Mirroring;
	public ESlateBrushImageType ImageType;
	public FDeprecateSlateVector2D ImageSize;
	public FMargin Margin;
	public FLinearColor Tint_DEPRECATED;
	public FSlateColor TintColor;
	public FSlateBrushOutlineSettings OutlineSettings;
	public UObject ResourceObject;
	public FName ResourceName;
	public FBox2f UVRegion;
}
