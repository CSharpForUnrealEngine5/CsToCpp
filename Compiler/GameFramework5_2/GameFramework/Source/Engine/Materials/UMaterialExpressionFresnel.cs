#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionFresnel.h")]
public partial class UMaterialExpressionFresnel : UMaterialExpression {
	///<summary>Defaults to &#39;Exponent&#39; if not specified</summary>
	public FExpressionInput ExponentIn;
	///<summary>The exponent to pass into the pow() function</summary>
	public float Exponent;
	///<summary>Defaults to &#39;BaseReflectFraction&#39; if not specified</summary>
	public FExpressionInput BaseReflectFractionIn;
	///<summary>Specifies the fraction of specular reflection when the surfaces is viewed from straight on.</summary>
	public float BaseReflectFraction;
	///<summary>Defaults to Pixel World Normal if not specified</summary>
	public FExpressionInput Normal;
}
