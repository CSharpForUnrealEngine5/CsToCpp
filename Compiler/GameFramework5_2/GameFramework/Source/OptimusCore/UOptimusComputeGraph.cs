#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusComputeGraph.h")]
public partial class UOptimusComputeGraph : UComputeGraph {
	public static UClass StaticClass() {return default;}
	///<summary>Lookup into Graphs array from the UComputeGraph kernel index.</summary>
	public TArray<TWeakObjectPtr<UOptimusNode>> KernelToNode;
}
