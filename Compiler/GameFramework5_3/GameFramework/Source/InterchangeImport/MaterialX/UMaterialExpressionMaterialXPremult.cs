namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Multiply the RGB channels of the input by the Alpha channel of the input.</summary>
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionPremult.h")]
public partial class UMaterialExpressionMaterialXPremult : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
}
