namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_ComputeKernelFunction.h")]
public partial class UOptimusNode_ComputeKernelFunctionGeneratorClass : UClass {
	public static UClass StaticClass() {return default;}
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
