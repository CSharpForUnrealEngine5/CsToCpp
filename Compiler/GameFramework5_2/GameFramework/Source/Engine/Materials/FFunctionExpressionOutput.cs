namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that stores information about a function output which is needed to maintain connections and implement the function call.</summary>
[CppInclude("Materials/MaterialExpressionMaterialFunctionCall.h")]
public partial struct FFunctionExpressionOutput {
	public UMaterialExpressionFunctionOutput ExpressionOutput;
	public FGuid ExpressionOutputId;
	public FExpressionOutput Output;
}
