#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStep.h")]
public partial class UMaterialExpressionStep : UMaterialExpression {
	///<summary>Defaults to &#39;ConstY&#39; if not specified</summary>
	public FExpressionInput Y;
	///<summary>Defaults to &#39;ConstX&#39; if not specified</summary>
	public FExpressionInput X;
	///<summary>only used if Y is not hooked up</summary>
	public float ConstY;
	///<summary>only used if X is not hooked up</summary>
	public float ConstX;
}
