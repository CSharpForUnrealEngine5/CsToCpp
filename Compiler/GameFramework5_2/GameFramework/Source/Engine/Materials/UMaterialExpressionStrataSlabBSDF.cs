#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataSlabBSDF : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Defines the diffused albedo, the percentage of light reflected as diffuse from the surface. (type = float3, unit = unitless, defaults to 0.18)</summary>
	public FExpressionInput DiffuseAlbedo;
	///<summary>Defines F0, the percentage of light reflected as specular from a surface when the view is perpendicular to the surface. (type = float3, unit = unitless, defaults to plastic 0.04)</summary>
	public FExpressionInput F0;
	///<summary>Defines F90, the percentage of light reflected as specular from a surface when the view is tangent to the surface. (type = float3, unit = unitless, defaults to 1.0f)</summary>
	public FExpressionInput F90;
	///<summary>Controls how rough the Material is. Roughness of 0 (smooth) is a mirror reflection and 1 (rough) is completely matte or diffuse. When using anisotropy, it is the roughness used along the Tangent axis. (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput Roughness;
	///<summary>Controls the anisotropy factor of the roughness. Positive value elongates the specular lobe along the Tangent vector, Negative value elongates the specular lobe along the perpendicular of the Tangent. (type = float, unit = unitless).</summary>
	public FExpressionInput Anisotropy;
	///<summary>Take the surface normal as input. The normal is considered tangent or world space according to the space properties on the main material node. (type = float3, unit = unitless, defaults to vertex normal)</summary>
	public FExpressionInput Normal;
	///<summary>Take a surface tangent as input. The tangent is considered tangent or world space according to the space properties on the main material node. (type = float3, unit = unitless, defaults to vertex tangent)</summary>
	public FExpressionInput Tangent;
	///<summary>Chromatic mean free path . Only used when there is not any sub-surface profile provided. (type = float3, unit = centimeters, default = 0)</summary>
	public FExpressionInput SSSMFP;
	///<summary>Scale the mean free path radius of the SSS profile according to a value between 0 and 1. Always used, when a subsurface profile is provided or not. (type = float, unitless, defaults to 1)</summary>
	public FExpressionInput SSSMFPScale;
	///<summary>Phase function anisotropy. Positive value elongates the phase function along the lignt direction, causing forward scattering. Negative value elongates the phase function backward to the light direction, causing backward scattering.  (type = float, unitless, defaults to 1, valid value -1..1)</summary>
	public FExpressionInput SSSPhaseAnisotropy;
	///<summary>Emissive color on top of the surface (type = float3, unit = luminance, default = 0)</summary>
	public FExpressionInput EmissiveColor;
	///<summary>Controls the roughness of a secondary specular lobe. Roughness of 0 (smooth) is a mirror reflection and 1 (rough) is completely matte or diffuse. Does not influence diffuse roughness. (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput SecondRoughness;
	///<summary>The weight of the second specular lobe using SecondRoughness. The first specular using Roughness will have a weight of (1 - SecondRoughnessWeight). (type = float, unitless, default = 0)</summary>
	public FExpressionInput SecondRoughnessWeight;
	///<summary>Controls how rough the Fuzz layer is. Roughness of 0 is smooth and 1 is rough. If FuzzRoughness Is not connected, the Roughness input will be used instead. (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput FuzzRoughness;
	///<summary>The amount of fuzz on top of the surface used to simulate cloth-like appearance.</summary>
	public FExpressionInput FuzzAmount;
	///<summary>The base color of the fuzz.</summary>
	public FExpressionInput FuzzColor;
	///<summary>SubsurfaceProfile, for Screen Space Subsurface Scattering. The profile needs to be set up on both the Substrate diffuse node, and the material node at the moment.</summary>
	public USubsurfaceProfile SubsurfaceProfile;
	///<summary>Whether to use light diffusion (i.e., SSS diffusion) or wrap-approximation for material with scattering behavior. This option trades quality over performance and will result into visual differences.</summary>
	public bool bUseSSSDiffusion;
}
