#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateBrush.h")]
///<summary>A brush which contains information about how to draw a Slate element</summary>
public partial struct FSlateBrush {
// SlateBrush
	public bool bIsDynamicallyLoaded;
	public bool bHasUObject_DEPRECATED;
	public byte DrawAs;
	public byte Tiling;
	public byte Mirroring;
	public byte ImageType;
	public FDeprecateSlateVector2D ImageSize;
	public FMargin Margin;
	public FLinearColor Tint_DEPRECATED;
	public FSlateColor TintColor;
	public FSlateBrushOutlineSettings OutlineSettings;
	public UObject ResourceObject;
	public string ResourceName;
	public FBox2f UVRegion;
}
