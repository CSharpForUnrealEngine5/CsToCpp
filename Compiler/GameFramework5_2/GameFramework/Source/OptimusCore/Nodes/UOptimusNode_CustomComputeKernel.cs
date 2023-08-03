#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_CustomComputeKernel.h")]
public partial class UOptimusNode_CustomComputeKernel : UOptimusNode_ComputeKernelBase {
	public static UClass StaticClass() {return default;}
	///<summary>FIXME: Use drop-down with a preset list + allow custom entry.</summary>
	public string Category;
	///<summary>Name of kernel. This is also used as the entry point function name in generated code.</summary>
	public FOptimusValidatedName KernelName;
	///<summary>The execution domain that this kernel operates on. The size of the domain is governed by</summary>
	public FOptimusExecutionDomain ExecutionDomain;
	///<summary>Number of threads in a thread group.</summary>
	public FIntVector GroupSize;
	///<summary>Parameters_DEPRECATED</summary>
	public TArray<FOptimus_ShaderBinding> Parameters_DEPRECATED;
	///<summary>Input bindings. Each one is a function that should be connected to an implementation in a data interface.</summary>
	public TArray<FOptimusParameterBinding> InputBindings_DEPRECATED;
	///<summary>Output bindings. Each one is a function that should be connected to an implementation in a data interface.</summary>
	public TArray<FOptimusParameterBinding> OutputBindings_DEPRECATED;
	///<summary>Input bindings. Each one is a function that should be connected to an implementation in a data interface.</summary>
	public FOptimusParameterBindingArray InputBindingArray;
	///<summary>Output bindings. Each one is a function that should be connected to an implementation in a data interface.</summary>
	public FOptimusParameterBindingArray OutputBindingArray;
	///<summary>Secondary bindings.</summary>
	public TArray<FOptimusSecondaryInputBindingsGroup> SecondaryInputBindingGroups;
	///<summary>Additional source includes.</summary>
	public TArray<UComputeSource> AdditionalSources;
	///<summary>The kernel source code.</summary>
	public FOptimusShaderText ShaderSource;
}
