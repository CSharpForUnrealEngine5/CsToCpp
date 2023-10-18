namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataUnlitBSDF : UMaterialExpressionStrataBSDF {
	public static UClass StaticClass() {return default;}
	///<summary>Emissive color on top of the surface (type = float3, unit = Luminance, default = 0)</summary>
	public FExpressionInput EmissiveColor;
	///<summary>The amount of transmitted light from the back side of the surface to the front side of the surface (type = float3, unit = unitless, defaults to 1)</summary>
	public FExpressionInput TransmittanceColor;
	///<summary>The surface normal. Only used for refraction effects when `IOR` or `pixel normal offset` modes are selected.</summary>
	public FExpressionInput Normal;
}
