#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ComputeGraph.h")]
///<summary>Class representing a Compute Graph.</summary>
public partial class UComputeGraph : UObject {
// ComputeGraph
	public TArray<UComputeKernel> KernelInvocations;
	public TArray<UComputeDataInterface> DataInterfaces;
	public TArray<FComputeGraphEdge> GraphEdges;
	public TArray<UClass> Bindings;
	public TArray<int> DataInterfaceToBinding;
}
