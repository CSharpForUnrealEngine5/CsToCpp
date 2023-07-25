#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataSingleLayerWaterBSDF : UMaterialExpressionStrataBSDF {
// MaterialExpressionStrataSingleLayerWaterBSDF
	public FExpressionInput BaseColor;
	public FExpressionInput Metallic;
	public FExpressionInput Specular;
	public FExpressionInput Roughness;
	public FExpressionInput Normal;
	public FExpressionInput EmissiveColor;
	public FExpressionInput TopMaterialOpacity;
	public FExpressionInput WaterAlbedo;
	public FExpressionInput WaterExtinction;
	public FExpressionInput WaterPhaseG;
	public FExpressionInput ColorScaleBehindWater;
}
