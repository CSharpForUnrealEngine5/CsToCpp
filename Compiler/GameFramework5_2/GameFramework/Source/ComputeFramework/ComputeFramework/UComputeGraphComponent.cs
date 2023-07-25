#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ComputeGraphComponent.h")]
///<summary>Component which holds a context for a UComputeGraph.</summary>
public partial class UComputeGraphComponent : UActorComponent {
// ComputeGraphComponent
	public UComputeGraph ComputeGraph;
	public void CreateDataProviders(int InBindingIndex,UObject InBindingObject) {}
	public void DestroyDataProviders() {}
	public void QueueExecute() {}
	public FComputeGraphInstance ComputeGraphInstance;
}
