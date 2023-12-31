namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that computes the length (magnitude) of a vector</summary>
[CppInclude("MaterialX/MaterialExpressionLength.h")]
public partial class UMaterialExpressionLength : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
}
