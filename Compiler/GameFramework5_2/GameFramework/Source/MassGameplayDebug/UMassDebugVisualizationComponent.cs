#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>meant to be created procedurally and owned by an AMassDebugVisualizer instance. Will ensure if placed on a different type of actor</summary>
[CppInclude("MassDebugVisualizationComponent.h")]
public partial class UMassDebugVisualizationComponent : UActorComponent {
	///<summary>VisualDataTable</summary>
	public TArray<FAgentDebugVisualization> VisualDataTable;
	///<summary>VisualDataISMCs</summary>
	public TArray<UHierarchicalInstancedStaticMeshComponent> VisualDataISMCs;
}
