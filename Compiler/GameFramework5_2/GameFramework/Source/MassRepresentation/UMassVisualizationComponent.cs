#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassVisualizationComponent.h")]
///<summary>This component handles all the static mesh instances for a MassRepresentationProcessor and is an actor component off a MassVisualizer actor.</summary>
public partial class UMassVisualizationComponent : UActorComponent {
// MassVisualizationComponent
	public TArray<FMassInstancedStaticMeshInfo> InstancedStaticMeshInfos;
}
