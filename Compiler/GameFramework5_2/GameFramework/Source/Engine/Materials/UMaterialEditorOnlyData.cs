#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/Material.h")]
public partial class UMaterialEditorOnlyData : UMaterialInterfaceEditorOnlyData {
// MaterialEditorOnlyData
	public FColorMaterialInput BaseColor;
	public FScalarMaterialInput Metallic;
	public FScalarMaterialInput Specular;
	public FScalarMaterialInput Roughness;
	public FScalarMaterialInput Anisotropy;
	public FVectorMaterialInput Normal;
	public FVectorMaterialInput Tangent;
	public FColorMaterialInput EmissiveColor;
	public FScalarMaterialInput Opacity;
	public FScalarMaterialInput OpacityMask;
	public FVectorMaterialInput WorldPositionOffset;
	public FColorMaterialInput SubsurfaceColor;
	public FScalarMaterialInput ClearCoat;
	public FScalarMaterialInput ClearCoatRoughness;
	public FScalarMaterialInput AmbientOcclusion;
	public FScalarMaterialInput Refraction;
	public FVector2MaterialInput CustomizedUVs;
	public FMaterialAttributesInput MaterialAttributes;
	public FScalarMaterialInput PixelDepthOffset;
	public FShadingModelMaterialInput ShadingModelFromMaterialExpression;
	public FScalarMaterialInput SurfaceThickness;
	public FStrataMaterialInput FrontMaterial;
	public FMaterialExpressionCollection ExpressionCollection;
	public TArray<FParameterGroupData> ParameterGroupData;
}
