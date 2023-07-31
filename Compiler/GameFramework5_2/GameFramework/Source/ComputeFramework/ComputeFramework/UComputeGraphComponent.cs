#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component which holds a context for a UComputeGraph.</summary>
[CppInclude("ComputeFramework/ComputeGraphComponent.h")]
public partial class UComputeGraphComponent : UActorComponent {
	///<summary>The Compute Graph asset.</summary>
	public UComputeGraph ComputeGraph;
	///<summary>Create all the Data Provider objects for a given binding object of the ComputeGraph.</summary>
	public  void CreateDataProviders(int InBindingIndex,UObject InBindingObject) {}
	///<summary>Destroy all associated DataProvider objects.</summary>
	public  void DestroyDataProviders() {}
	///<summary>Queue the graph for execution at the next render update.</summary>
	public  void QueueExecute() {}
	///<summary>ComputeGraphInstance</summary>
	public FComputeGraphInstance ComputeGraphInstance;
}
