#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Divide the RGB channels of the input by the Alpha channel of the input. If the</summary>
[CppInclude("MaterialX/MaterialExpressionUnpremult.h")]
public partial class UMaterialExpressionUnpremult : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
}
