namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataLegacyConversion : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Defines the overall color of the Material. (type = float3, unit = unitless, defaults to 0.18)</summary>
	public FExpressionInput BaseColor;
	///<summary>Controls how \&quot;metal-like\&quot; your surface looks like. 0 means dielectric, 1 means conductor (type = float, unit = unitless, defaults to 0)</summary>
	public FExpressionInput Metallic;
	///<summary>Used to scale the current amount of specularity on non-metallic surfaces and is a value between 0 and 1 (type = float, unit = unitless, defaults to plastic 0.5)</summary>
	public FExpressionInput Specular;
	///<summary>Controls how rough the Material is. Roughness of 0 (smooth) is a mirror reflection and 1 (rough) is completely matte or diffuse. When using anisotropy, it is the roughness used along the Tangent axis. (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput Roughness;
	///<summary>Controls the anisotropy factor of the roughness. Positive value elongates the specular lobe along the Tangent vector, Negative value elongates the specular lobe along the perpendicular of the Tangent. (type = float, unit = unitless).</summary>
	public FExpressionInput Anisotropy;
	///<summary>Emissive color on top of the surface (type = float3, unit = luminance, default = 0)</summary>
	public FExpressionInput EmissiveColor;
	///<summary>Take the surface normal as input. The normal is considered tangent or world space according to the space properties on the main material node. (type = float3, unit = unitless, defaults to vertex normal)</summary>
	public FExpressionInput Normal;
	///<summary>Take a surface tangent as input. The tangent is considered tangent or world space according to the space properties on the main material node. (type = float3, unit = unitless, defaults to vertex tangent)</summary>
	public FExpressionInput Tangent;
	///<summary>Scale the mean free path radius of the SSS profile according to a value between 0 and 1. Always used, when a subsurface profile is provided or not. (type = float, unitless, defaults to 1)</summary>
	public FExpressionInput SubSurfaceColor;
	///<summary>Coverage of the clear coat layer. (type = float, unit = unitless, defaults to 0.0)</summary>
	public FExpressionInput ClearCoat;
	///<summary>Roughness of the top clear coat layer. (type = float, unit = unitless, defaults to 0.0)</summary>
	public FExpressionInput ClearCoatRoughness;
	///<summary>Opacity of the material</summary>
	public FExpressionInput Opacity;
	///<summary>The amount of transmitted light from the back side of the surface to the front side of the surface (type = float3, unit = unitless, defaults to 1)</summary>
	public FExpressionInput TransmittanceColor;
	///<summary>The single scattering Albedo defining the overall color of the Material (type = float3, unit = unitless, default = 0)</summary>
	public FExpressionInput WaterScatteringCoefficients;
	///<summary>The rate at which light is absorbed or out-scattered by the medium. Mean Free Path = 1 / Extinction. (type = float3, unit = 1/cm, default = 0)</summary>
	public FExpressionInput WaterAbsorptionCoefficients;
	///<summary>Anisotropy of the volume with values lower than 0 representing back-scattering, equal 0 representing isotropic scattering and greater than 0 representing forward scattering. (type = float, unit = unitless, defaults to 0)</summary>
	public FExpressionInput WaterPhaseG;
	///<summary>A scale to apply on the scene color behind the water surface. It can be used to approximate caustics for instance. (type = float3, unit = unitless, defaults to 1)</summary>
	public FExpressionInput ColorScaleBehindWater;
	///<summary>Take the bottom clear coat surface normal as input. The normal is considered tangent or world space according to the space properties on the main material node. (type = float3, unit = unitless, defaults to vertex normal)</summary>
	public FExpressionInput ClearCoatNormal;
	///<summary>Take the tangent output node as input. The tangent is considered tangent or world space according to the space properties on the main material node. (type = float3, unit = unitless, defaults to vertex tangent)</summary>
	public FExpressionInput CustomTangent;
	///<summary>Shading models</summary>
	public FShadingModelMaterialInput ShadingModel;
	///<summary>SubsurfaceProfile, for Screen Space Subsurface Scattering. The profile needs to be set up on both the Substrate diffuse node, and the material node at the moment.</summary>
	public USubsurfaceProfile SubsurfaceProfile;
	///<summary>Store converted material models.</summary>
	public FStrataMaterialInfo ConvertedStrataMaterialInfo;
}
