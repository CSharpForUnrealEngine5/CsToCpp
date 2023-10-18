namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystem responsible for all visual of mass agents, will handle actors spawning and static mesh instances</summary>
[CppInclude("MassRepresentationSubsystem.h")]
public partial class UMassRepresentationSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>The array of all the template actors</summary>
	public TArray<UClass> TemplateActors;
	///<summary>The component that handles all the static mesh instances</summary>
	public UMassVisualizationComponent VisualizationComponent;
	///<summary>The actor owning the above visualization component</summary>
	public AMassVisualizer Visualizer;
	///<summary>ActorSpawnerSubsystem</summary>
	public UMassActorSpawnerSubsystem ActorSpawnerSubsystem;
	///<summary>WorldPartitionSubsystem</summary>
	public UWorldPartitionSubsystem WorldPartitionSubsystem;
}
