namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataThinFilm : UMaterialExpressionStrataUtilityBase {
	public static UClass StaticClass() {return default;}
	///<summary>The normal of the surface to consider. This input respects the normal space setup on the root node (tangent or world)</summary>
	public FExpressionInput Normal;
	///<summary>Defines the color and brightness of the specular highlight where the surface is facing the camera. Each specular contribution will fade to black as F0 drops below 0.02. (type = float3, unit = unitless, defaults to plastic 0.04)</summary>
	public FExpressionInput F0;
	///<summary>Defines the color of the specular highlight where the surface normal is 90 degrees from the view direction. Only the hue and saturation are preserved, the brightness is fixed at 1.0. Fades to black as F0 drops below 0.02. (type = float3, unit = unitless, defaults to 1.0f)</summary>
	public FExpressionInput F90;
	///<summary>Thin film controls the thin film layer coating the current slab. 0 means disabled and 1 means a coating layer of 10 micrometer. (type = float, unitless, default = 0)</summary>
	public FExpressionInput Thickness;
	///<summary>Thin film IOR</summary>
	public FExpressionInput IOR;
}
