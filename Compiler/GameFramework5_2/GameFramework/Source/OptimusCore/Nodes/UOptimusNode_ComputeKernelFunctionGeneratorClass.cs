#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_ComputeKernelFunction.h")]
public partial class UOptimusNode_ComputeKernelFunctionGeneratorClass : UClass {
	///<summary>Category</summary>
	public string Category;
	///<summary>KernelName</summary>
	public string KernelName;
	///<summary>ExecutionDomain</summary>
	public FOptimusExecutionDomain ExecutionDomain;
	///<summary>GroupSize</summary>
	public FIntVector GroupSize;
	///<summary>InputBindings</summary>
	public TArray<FOptimusParameterBinding> InputBindings;
	///<summary>OutputBindings</summary>
	public TArray<FOptimusParameterBinding> OutputBindings;
	///<summary>ShaderSource</summary>
	public string ShaderSource;
}
