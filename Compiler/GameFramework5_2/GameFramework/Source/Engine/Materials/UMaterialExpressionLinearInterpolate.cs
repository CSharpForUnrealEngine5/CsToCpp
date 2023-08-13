namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionLinearInterpolate.h")]
public partial class UMaterialExpressionLinearInterpolate : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstA&#39; if not specified</summary>
	public FExpressionInput A;
	///<summary>Defaults to &#39;ConstB&#39; if not specified</summary>
	public FExpressionInput B;
	///<summary>Defaults to &#39;ConstAlpha&#39; if not specified</summary>
	public FExpressionInput Alpha;
	///<summary>only used if A is not hooked up</summary>
	public float ConstA;
	///<summary>only used if B is not hooked up</summary>
	public float ConstB;
	///<summary>only used if Alpha is not hooked up</summary>
	public float ConstAlpha;
}
