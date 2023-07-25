#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ComputeGraph.h")]
///<summary>Description of a single edge in a UComputeGraph.</summary>
public partial struct FComputeGraphEdge {
// ComputeGraphEdge
	public int KernelIndex;
	public int KernelBindingIndex;
	public int DataInterfaceIndex;
	public int DataInterfaceBindingIndex;
	public bool bKernelInput;
	public string BindingFunctionNameOverride;
	public string BindingFunctionNamespace;
}
