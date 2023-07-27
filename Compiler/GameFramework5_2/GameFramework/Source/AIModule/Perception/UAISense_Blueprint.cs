#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Blueprint.h")]
public partial class UAISense_Blueprint : UAISense {
// AISense_Blueprint
	public UClass ListenerDataType;
	public TArray<UAIPerceptionComponent> ListenerContainer;
	public TArray<UAISenseEvent> UnprocessedEvents;
	public  float OnUpdate(TArray<UAISenseEvent> EventsToProcess) { return default; }
	public  void OnListenerRegistered(AActor ActorListener,UAIPerceptionComponent PerceptionComponent) {}
	public  void OnListenerUpdated(AActor ActorListener,UAIPerceptionComponent PerceptionComponent) {}
	public  void OnListenerUnregistered(AActor ActorListener,UAIPerceptionComponent PerceptionComponent) {}
	public  void GetAllListenerActors(TArray<AActor> ListenerActors) {}
	public  void GetAllListenerComponents(TArray<UAIPerceptionComponent> ListenerComponents) {}
	public  void K2_OnNewPawn(APawn NewPawn) {}
}
