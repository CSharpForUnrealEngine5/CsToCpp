#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataEyeBSDF : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Hair fiber base color resulting from single and multiple scattering combined. (type = float3, unit = unitless, defaults to black)</summary>
	public FExpressionInput DiffuseColor;
	///<summary>Controls how rough the Material is. Roughness of 0 (smooth) is a mirror reflection and 1 (rough) is completely matte or diffuse (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput Roughness;
	///<summary>Normal of the sclera and cornea (type = float3, unit = unitless, defaults to +X vector)</summary>
	public FExpressionInput CorneaNormal;
	///<summary>Normal of the iris (type = float3, unit = unitless, defaults to +X vector)</summary>
	public FExpressionInput IrisNormal;
	///<summary>Normal of the iris plane (type = float3, unit = unitless, defaults to +X vector)</summary>
	public FExpressionInput IrisPlaneNormal;
	///<summary>Mask defining the iris surface (type = float, unit = unitless, defaults to 0.0)</summary>
	public FExpressionInput IrisMask;
	///<summary>Distance from the center of the iris (type = float, unit = unitless, defaults to 0.0)</summary>
	public FExpressionInput IrisDistance;
	///<summary>Emissive color on top of the surface (type = float3, unit = luminance, defaults to 0.0)</summary>
	public FExpressionInput EmissiveColor;
	///<summary>SubsurfaceProfile, for Subsurface Scattering diffusion.</summary>
	public USubsurfaceProfile SubsurfaceProfile;
}
