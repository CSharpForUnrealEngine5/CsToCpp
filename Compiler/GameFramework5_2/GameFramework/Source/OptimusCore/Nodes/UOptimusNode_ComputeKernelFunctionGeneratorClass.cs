#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_ComputeKernelFunction.h")]
public partial class UOptimusNode_ComputeKernelFunctionGeneratorClass : UClass {
// OptimusNode_ComputeKernelFunctionGeneratorClass
	public string Category;
	public string KernelName;
	public FOptimusExecutionDomain ExecutionDomain;
	public FIntVector GroupSize;
	public TArray<FOptimusParameterBinding> InputBindings;
	public TArray<FOptimusParameterBinding> OutputBindings;
	public string ShaderSource;
}
