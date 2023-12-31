namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Multiply the RGB channels of the input by the Alpha channel of the input.</summary>
[CppInclude("MaterialX/MaterialExpressionPremult.h")]
public partial class UMaterialExpressionPremult : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
}
