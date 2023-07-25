#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataLegacyConversion : UMaterialExpressionStrataBSDF {
// MaterialExpressionStrataLegacyConversion
	public FExpressionInput BaseColor;
	public FExpressionInput Metallic;
	public FExpressionInput Specular;
	public FExpressionInput Roughness;
	public FExpressionInput Anisotropy;
	public FExpressionInput EmissiveColor;
	public FExpressionInput Normal;
	public FExpressionInput Tangent;
	public FExpressionInput SubSurfaceColor;
	public FExpressionInput ClearCoat;
	public FExpressionInput ClearCoatRoughness;
	public FExpressionInput Opacity;
	public FExpressionInput TransmittanceColor;
	public FExpressionInput WaterScatteringCoefficients;
	public FExpressionInput WaterAbsorptionCoefficients;
	public FExpressionInput WaterPhaseG;
	public FExpressionInput ColorScaleBehindWater;
	public FExpressionInput ClearCoatNormal;
	public FExpressionInput CustomTangent;
	public FShadingModelMaterialInput ShadingModel;
	public USubsurfaceProfile SubsurfaceProfile;
	public FStrataMaterialInfo ConvertedStrataMaterialInfo;
}
