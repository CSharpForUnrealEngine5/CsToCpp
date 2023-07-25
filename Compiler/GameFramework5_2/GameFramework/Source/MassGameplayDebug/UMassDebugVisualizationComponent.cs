#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassDebugVisualizationComponent.h")]
///<summary>meant to be created procedurally and owned by an AMassDebugVisualizer instance. Will ensure if placed on a different type of actor</summary>
public partial class UMassDebugVisualizationComponent : UActorComponent {
// MassDebugVisualizationComponent
	public TArray<FAgentDebugVisualization> VisualDataTable;
	public TArray<UHierarchicalInstancedStaticMeshComponent> VisualDataISMCs;
}
