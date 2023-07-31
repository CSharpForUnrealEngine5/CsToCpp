#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionMaterialFunctionCall.h")]
public partial class UMaterialExpressionMaterialFunctionCall : UMaterialExpression {
	///<summary>The function to call.</summary>
	public UMaterialFunctionInterface MaterialFunction;
	///<summary>Array of all the function inputs that this function exposes.</summary>
	public TArray<FFunctionExpressionInput> FunctionInputs;
	///<summary>Array of all the function outputs that this function exposes.</summary>
	public TArray<FFunctionExpressionOutput> FunctionOutputs;
	///<summary>Used by material parameters to split references to separate instances.</summary>
	public FMaterialParameterInfo FunctionParameterInfo;
	///<summary>SetMaterialFunction</summary>
	public  bool SetMaterialFunction(UMaterialFunctionInterface NewMaterialFunction) { return default; }
}
