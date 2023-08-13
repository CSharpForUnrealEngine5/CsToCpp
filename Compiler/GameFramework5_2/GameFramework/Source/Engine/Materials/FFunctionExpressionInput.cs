namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that stores information about a function input which is needed to maintain connections and implement the function call.</summary>
[CppInclude("Materials/MaterialExpressionMaterialFunctionCall.h")]
public partial struct FFunctionExpressionInput {
	public UMaterialExpressionFunctionInput ExpressionInput;
	public FGuid ExpressionInputId;
	public FExpressionInput Input;
}
