namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that computes the exponential of an input</summary>
[CppInclude("MaterialX/MaterialExpressionExponential.h")]
public partial class UMaterialExpressionExponential : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
}
