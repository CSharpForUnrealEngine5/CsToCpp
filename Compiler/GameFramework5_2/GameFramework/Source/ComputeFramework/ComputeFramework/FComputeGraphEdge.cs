#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Description of a single edge in a UComputeGraph.</summary>
[CppInclude("ComputeFramework/ComputeGraph.h")]
public partial struct FComputeGraphEdge {
	public int KernelIndex;
	public int KernelBindingIndex;
	public int DataInterfaceIndex;
	public int DataInterfaceBindingIndex;
	public bool bKernelInput;
	public string BindingFunctionNameOverride;
	public string BindingFunctionNamespace;
}
