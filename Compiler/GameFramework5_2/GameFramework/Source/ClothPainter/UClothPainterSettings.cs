#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothPaintSettings.h")]
public partial class UClothPainterSettings : UMeshPaintSettings {
// ClothPainterSettings
	public float ViewMin;
	public float ViewMax;
	public bool bAutoViewRange;
	public float AutoCalculatedViewMin;
	public float AutoCalculatedViewMax;
	public TArray<UClothingAssetCommon> ClothingAssets;
	public bool bFlipNormal;
	public bool bCullBackface;
	public float Opacity;
}
