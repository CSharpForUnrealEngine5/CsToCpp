#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/Material.h")]
public partial class UMaterialEditorOnlyData : UMaterialInterfaceEditorOnlyData {
	public static UClass StaticClass() {return default;}
	///<summary>Reflection</summary>
	public FColorMaterialInput BaseColor;
	///<summary>Metallic</summary>
	public FScalarMaterialInput Metallic;
	///<summary>Specular</summary>
	public FScalarMaterialInput Specular;
	///<summary>Roughness</summary>
	public FScalarMaterialInput Roughness;
	///<summary>Anisotropy</summary>
	public FScalarMaterialInput Anisotropy;
	///<summary>Normal</summary>
	public FVectorMaterialInput Normal;
	///<summary>Tangent</summary>
	public FVectorMaterialInput Tangent;
	///<summary>EmissiveColor</summary>
	public FColorMaterialInput EmissiveColor;
	///<summary>Transmission.</summary>
	public FScalarMaterialInput Opacity;
	///<summary>OpacityMask</summary>
	public FScalarMaterialInput OpacityMask;
	///<summary>Adds to world position in the vertex shader.</summary>
	public FVectorMaterialInput WorldPositionOffset;
	///<summary>Inner material color, only used for ShadingModel=Subsurface</summary>
	public FColorMaterialInput SubsurfaceColor;
	///<summary>ClearCoat</summary>
	public FScalarMaterialInput ClearCoat;
	///<summary>ClearCoatRoughness</summary>
	public FScalarMaterialInput ClearCoatRoughness;
	///<summary>output ambient occlusion to the GBuffer</summary>
	public FScalarMaterialInput AmbientOcclusion;
	///<summary>output refraction index for translucent rendering</summary>
	public FScalarMaterialInput Refraction;
	///<summary>These inputs are evaluated in the vertex shader and allow artists to do arbitrary vertex shader operations and access them in the pixel shader.</summary>
	public FVector2MaterialInput CustomizedUVs;
	///<summary>MaterialAttributes</summary>
	public FMaterialAttributesInput MaterialAttributes;
	///<summary>PixelDepthOffset</summary>
	public FScalarMaterialInput PixelDepthOffset;
	///<summary>ShadingModelFromMaterialExpression</summary>
	public FShadingModelMaterialInput ShadingModelFromMaterialExpression;
	///<summary>SurfaceThickness</summary>
	public FScalarMaterialInput SurfaceThickness;
	///<summary>FrontMaterial</summary>
	public FStrataMaterialInput FrontMaterial;
	///<summary>ExpressionCollection</summary>
	public FMaterialExpressionCollection ExpressionCollection;
	///<summary>Controls where this parameter group is displayed in a material instance parameter list.  The lower the number the higher up in the parameter list.</summary>
	public TArray<FParameterGroupData> ParameterGroupData;
}
