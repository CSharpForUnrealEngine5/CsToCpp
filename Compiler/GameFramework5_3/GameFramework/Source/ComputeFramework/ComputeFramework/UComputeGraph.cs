namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class representing a Compute Graph.</summary>
[CppInclude("ComputeFramework/ComputeGraph.h")]
public partial class UComputeGraph : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Kernels in the graph.</summary>
	public TArray<UComputeKernel> KernelInvocations;
	///<summary>Data interfaces in the graph.</summary>
	public TArray<UComputeDataInterface> DataInterfaces;
	///<summary>Edges in the graph between kernels and data interfaces.</summary>
	public TArray<FComputeGraphEdge> GraphEdges;
	///<summary>Registered binding object class types.</summary>
	public TArray<UClass> Bindings;
	///<summary>Mapping of DataInterfaces array index to Bindings index.</summary>
	public TArray<int> DataInterfaceToBinding;
}
