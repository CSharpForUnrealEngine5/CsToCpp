#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationSubsystem.h")]
///<summary>Subsystem responsible for all visual of mass agents, will handle actors spawning and static mesh instances</summary>
public partial class UMassRepresentationSubsystem : UWorldSubsystem {
// MassRepresentationSubsystem
	public TArray<UClass> TemplateActors;
	public UMassVisualizationComponent VisualizationComponent;
	public AMassVisualizer Visualizer;
	public UMassActorSpawnerSubsystem ActorSpawnerSubsystem;
	public UWorldPartitionSubsystem WorldPartitionSubsystem;
}
