#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blend nodes take two 1-4 channel inputs and apply the same operator to all channels.</summary>
[CppInclude("MaterialX/MaterialExpressionPlus.h")]
public partial class UMaterialExpressionPlus : UMaterialExpression {
	///<summary>A</summary>
	public FExpressionInput A;
	///<summary>B</summary>
	public FExpressionInput B;
	///<summary>Defaults to &#39;ConstAlpha&#39; if not specified</summary>
	public FExpressionInput Alpha;
	///<summary>only used if Alpha is not hooked up</summary>
	public float ConstAlpha;
}
