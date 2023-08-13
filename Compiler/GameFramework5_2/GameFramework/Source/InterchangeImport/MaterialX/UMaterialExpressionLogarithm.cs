namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that computes the natural logarithm</summary>
[CppInclude("MaterialX/MaterialExpressionLogarithm.h")]
public partial class UMaterialExpressionLogarithm : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
}
