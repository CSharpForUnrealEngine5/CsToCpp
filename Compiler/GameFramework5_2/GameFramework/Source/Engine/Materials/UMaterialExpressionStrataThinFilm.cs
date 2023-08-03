#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStrata.h")]
public partial class UMaterialExpressionStrataThinFilm : UMaterialExpressionStrataUtilityBase {
	public static UClass StaticClass() {return default;}
	///<summary>The normal of the surface to consider. This input respects the normal space setup on the root node (tangent or world)</summary>
	public FExpressionInput Normal;
	///<summary>Defines F0, the percentage of light reflected as specular from a surface when the view is perpendicular to the surface. (type = float3, unit = unitless, defaults to plastic 0.04)</summary>
	public FExpressionInput F0;
	///<summary>Defines F90, the percentage of light reflected as specular from a surface when the view is tangent to the surface. (type = float3, unit = unitless, defaults to 1.0f)</summary>
	public FExpressionInput F90;
	///<summary>Thin film controls the thin film layer coating the current slab. 0 means disabled and 1 means a coating layer of 10 micrometer. (type = float, unitless, default = 0)</summary>
	public FExpressionInput Thickness;
	///<summary>Thin film IOR</summary>
	public FExpressionInput IOR;
}
