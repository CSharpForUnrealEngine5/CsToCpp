namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataSingleLayerWaterBSDF : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Surface base color. (type = float3, unit = unitless, defaults to black)</summary>
	public FExpressionInput BaseColor;
	///<summary>Whether the surface represents a dielectric (such as plastic) or a conductor (such as metal). (type = float, unit = unitless, defaults to 0 = dielectric)</summary>
	public FExpressionInput Metallic;
	///<summary>Specular amount (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput Specular;
	///<summary>Controls how rough the Material is. Roughness of 0 (smooth) is a mirror reflection and 1 (rough) is completely matte or diffuse (type = float, unit = unitless, defaults to 0.5)</summary>
	public FExpressionInput Roughness;
	///<summary>The normal of the surface (type = float3, unit = unitless, defaults to +Z vector)</summary>
	public FExpressionInput Normal;
	///<summary>Emissive color on top of the surface (type = float3, unit = luminance, defaults to 0.0)</summary>
	public FExpressionInput EmissiveColor;
	///<summary>Opacity of the material layered on top of the water (type = float3, unit = unitless, defaults to 0.0)</summary>
	public FExpressionInput TopMaterialOpacity;
	///<summary>The single scattering Albedo defining the overall color of the Material (type = float3, unit = unitless, default = 0)</summary>
	public FExpressionInput WaterAlbedo;
	///<summary>The rate at which light is absorbed or out-scattered by the medium. Mean Free Path = 1 / Extinction. (type = float3, unit = 1/cm, default = 0)</summary>
	public FExpressionInput WaterExtinction;
	///<summary>Anisotropy of the volume with values lower than 0 representing back-scattering, equal 0 representing isotropic scattering and greater than 0 representing forward scattering. (type = float, unit = unitless, defaults to 0)</summary>
	public FExpressionInput WaterPhaseG;
	///<summary>A scale to apply on the scene color behind the water surface. It can be used to approximate caustics for instance. (type = float3, unit = unitless, defaults to 1)</summary>
	public FExpressionInput ColorScaleBehindWater;
}
