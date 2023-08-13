namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStep.h")]
public partial class UMaterialExpressionStep : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstY&#39; if not specified</summary>
	public FExpressionInput Y;
	///<summary>Defaults to &#39;ConstX&#39; if not specified</summary>
	public FExpressionInput X;
	///<summary>only used if Y is not hooked up</summary>
	public float ConstY;
	///<summary>only used if X is not hooked up</summary>
	public float ConstX;
}
