namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSphericalParticleOpacity.h")]
public partial class UMaterialExpressionSphericalParticleOpacity : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstantDensity&#39; if not specified</summary>
	public FExpressionInput Density;
	///<summary>Constant density of the particle sphere.  Will be overridden if Density is connected.</summary>
	public float ConstantDensity;
}
