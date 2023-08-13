namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPower.h")]
public partial class UMaterialExpressionPower : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Base</summary>
	public FExpressionInput Base;
	///<summary>Defaults to &#39;ConstExponent&#39; if not specified</summary>
	public FExpressionInput Exponent;
	///<summary>only used if Exponent is not hooked up</summary>
	public float ConstExponent;
}
