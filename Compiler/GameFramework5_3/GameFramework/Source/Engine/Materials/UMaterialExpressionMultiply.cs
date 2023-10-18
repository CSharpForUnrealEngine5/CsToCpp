namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionMultiply.h")]
public partial class UMaterialExpressionMultiply : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstA&#39; if not specified</summary>
	public FExpressionInput A;
	///<summary>Defaults to &#39;ConstB&#39; if not specified</summary>
	public FExpressionInput B;
	///<summary>only used if A is not hooked up</summary>
	public float ConstA;
	///<summary>only used if B is not hooked up</summary>
	public float ConstB;
}
