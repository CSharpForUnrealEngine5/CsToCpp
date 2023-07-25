#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Blueprint.h")]
public partial class UAISense_Blueprint : UAISense {
// AISense_Blueprint
	public UClass ListenerDataType;
	public TArray<UAIPerceptionComponent> ListenerContainer;
	public TArray<UAISenseEvent> UnprocessedEvents;
	public float OnUpdate(TArray<UObject> EventsToProcess) { return default; }
	public void OnListenerRegistered(UObject ActorListener,UObject PerceptionComponent) {}
	public void OnListenerUpdated(UObject ActorListener,UObject PerceptionComponent) {}
	public void OnListenerUnregistered(UObject ActorListener,UObject PerceptionComponent) {}
	public void GetAllListenerActors(TArray<UObject> ListenerActors) {}
	public void GetAllListenerComponents(TArray<UObject> ListenerComponents) {}
	public void K2_OnNewPawn(UObject NewPawn) {}
}
