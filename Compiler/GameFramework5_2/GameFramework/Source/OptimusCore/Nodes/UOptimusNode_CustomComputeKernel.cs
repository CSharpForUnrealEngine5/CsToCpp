#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_CustomComputeKernel.h")]
public partial class UOptimusNode_CustomComputeKernel : UOptimusNode_ComputeKernelBase {
// OptimusNode_CustomComputeKernel
	public string Category;
	public FOptimusValidatedName KernelName;
	public FOptimusExecutionDomain ExecutionDomain;
	public FIntVector GroupSize;
	public TArray<FOptimus_ShaderBinding> Parameters_DEPRECATED;
	public TArray<FOptimusParameterBinding> InputBindings_DEPRECATED;
	public TArray<FOptimusParameterBinding> OutputBindings_DEPRECATED;
	public FOptimusParameterBindingArray InputBindingArray;
	public FOptimusParameterBindingArray OutputBindingArray;
	public TArray<FOptimusSecondaryInputBindingsGroup> SecondaryInputBindingGroups;
	public TArray<UComputeSource> AdditionalSources;
	public FOptimusShaderText ShaderSource;
}
