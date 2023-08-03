#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataHairBSDF : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Hair fiber base color resulting from single and multiple scattering combined. (type = float3, unit = unitless, defaults to black)</summary>
	public FExpressionInput BaseColor;
	///<summary>Amount of light scattering, only available for non-HairStrand rendering (type = float, unit = unitless, defaults to 0.0)</summary>
	public FExpressionInput Scatter;
	///<summary>Specular (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput Specular;
	///<summary>Controls how rough the Material is. Roughness of 0 (smooth) is a mirror reflection and 1 (rough) is completely matte or diffuse (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput Roughness;
	///<summary>How much light contributs when lighting hairs from the back side opposite from the view, only available for HairStrand rendering (type = float3, unit = unitless, defaults to 0.0)</summary>
	public FExpressionInput Backlit;
	///<summary>Tangent (type = float3, unit = unitless, defaults to +X vector)</summary>
	public FExpressionInput Tangent;
	///<summary>Emissive color on top of the surface (type = float3, unit = luminance, defaults to 0.0)</summary>
	public FExpressionInput EmissiveColor;
}
