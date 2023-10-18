namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Divide the RGB channels of the input by the Alpha channel of the input. If the</summary>
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionUnpremult.h")]
public partial class UMaterialExpressionMaterialXUnpremult : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
}
