#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionMaterialFunctionCall.h")]
///<summary>Struct that stores information about a function input which is needed to maintain connections and implement the function call.</summary>
public partial struct FFunctionExpressionInput {
// FunctionExpressionInput
	public UMaterialExpressionFunctionInput ExpressionInput;
	public FGuid ExpressionInputId;
	public FExpressionInput Input;
}
