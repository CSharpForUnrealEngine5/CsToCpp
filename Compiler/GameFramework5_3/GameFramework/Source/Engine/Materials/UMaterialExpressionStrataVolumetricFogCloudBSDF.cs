namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataVolumetricFogCloudBSDF : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>The single scattering Albedo defining the overall color of the Material (type = float3, unit = unitless, default = 0)</summary>
	public FExpressionInput Albedo;
	///<summary>The rate at which light is absorbed or scattered by the medium. Mean Free Path = 1 / Extinction. (type = float3, unit = 1/m, default = 0)</summary>
	public FExpressionInput Extinction;
	///<summary>Emissive color of the medium (type = float3, unit = luminance, default = 0)</summary>
	public FExpressionInput EmissiveColor;
	///<summary>Ambient occlusion: 1 means no occlusion while 0 means fully occluded. (type = float, unit = unitless, default = 1)</summary>
	public FExpressionInput AmbientOcclusion;
}
