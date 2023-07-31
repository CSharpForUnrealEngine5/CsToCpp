#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSphericalParticleOpacity.h")]
public partial class UMaterialExpressionSphericalParticleOpacity : UMaterialExpression {
	///<summary>Defaults to &#39;ConstantDensity&#39; if not specified</summary>
	public FExpressionInput Density;
	///<summary>Constant density of the particle sphere.  Will be overridden if Density is connected.</summary>
	public float ConstantDensity;
}
