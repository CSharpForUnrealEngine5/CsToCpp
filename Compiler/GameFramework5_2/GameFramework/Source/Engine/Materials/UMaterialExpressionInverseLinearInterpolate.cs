#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionInverseLinearInterpolate.h")]
public partial class UMaterialExpressionInverseLinearInterpolate : UMaterialExpression {
	///<summary>Defaults to &#39;ConstA&#39; if not specified</summary>
	public FExpressionInput A;
	///<summary>Defaults to &#39;ConstB&#39; if not specified</summary>
	public FExpressionInput B;
	///<summary>Defaults to &#39;ConstValue&#39; if not specified</summary>
	public FExpressionInput Value;
	///<summary>only used if A is not hooked up</summary>
	public float ConstA;
	///<summary>only used if B is not hooked up</summary>
	public float ConstB;
	///<summary>only used if Value is not hooked up</summary>
	public float ConstValue;
	///<summary>Clamp the result to 0 to 1</summary>
	public bool bClampResult;
}
