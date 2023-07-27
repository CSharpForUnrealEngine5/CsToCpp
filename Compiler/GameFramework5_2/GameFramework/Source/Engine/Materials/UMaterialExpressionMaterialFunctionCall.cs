#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionMaterialFunctionCall.h")]
public partial class UMaterialExpressionMaterialFunctionCall : UMaterialExpression {
// MaterialExpressionMaterialFunctionCall
	public UMaterialFunctionInterface MaterialFunction;
	public TArray<FFunctionExpressionInput> FunctionInputs;
	public TArray<FFunctionExpressionOutput> FunctionOutputs;
	public FMaterialParameterInfo FunctionParameterInfo;
	public  bool SetMaterialFunction(UMaterialFunctionInterface NewMaterialFunction) { return default; }
}
