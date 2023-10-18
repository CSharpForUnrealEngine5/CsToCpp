namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataSimpleClearCoatBSDF : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Defines the diffused albedo, the percentage of light reflected as diffuse from the surface. (type = float3, unit = unitless, defaults to 0.18)</summary>
	public FExpressionInput DiffuseAlbedo;
	///<summary>Defines the color and brightness of the specular highlight where the surface is facing the camera. Each specular contribution will fade to black as F0 drops below 0.02. (type = float3, unit = unitless, defaults to plastic 0.04)</summary>
	public FExpressionInput F0;
	///<summary>Controls how rough the bottom layer of the material is. Roughness of 0 (smooth) is a mirror reflection and 1 (rough) is completely matte or diffuse. (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput Roughness;
	///<summary>Controls the coverage of the clear coat layer: 0 means no clear coat, 1 means coat is fully visible. (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput ClearCoatCoverage;
	///<summary>Controls how rough the top layer of the material is. Roughness of 0 (smooth) is a mirror reflection and 1 (rough) is completely matte or diffuse. (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput ClearCoatRoughness;
	///<summary>Take the surface normal as input. The normal is considered tangent or world space according to the space properties on the main material node. (type = float3, unit = unitless, defaults to vertex normal)</summary>
	public FExpressionInput Normal;
	///<summary>Emissive color of the medium (type = float3, unit = luminance, default = 0)</summary>
	public FExpressionInput EmissiveColor;
}
