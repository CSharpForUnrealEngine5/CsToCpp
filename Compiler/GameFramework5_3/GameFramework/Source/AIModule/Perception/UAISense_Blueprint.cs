namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Blueprint.h")]
public partial class UAISense_Blueprint : UAISense {
	public static UClass StaticClass() {return default;}
	///<summary>ListenerDataType</summary>
	public UClass ListenerDataType;
	///<summary>ListenerContainer</summary>
	public TArray<UAIPerceptionComponent> ListenerContainer;
	///<summary>UnprocessedEvents</summary>
	public TArray<UAISenseEvent> UnprocessedEvents;
	///<summary>returns requested amount of time to pass until next frame.</summary>
	public float OnUpdate(TArray<UAISenseEvent> EventsToProcess) { return default; }
	///<summary>@param PerceptionComponent is ActorListener&#39;s AIPerceptionComponent instance</summary>
	public void OnListenerRegistered(AActor ActorListener,UAIPerceptionComponent PerceptionComponent) {}
	///<summary>@param PerceptionComponent is ActorListener&#39;s AIPerceptionComponent instance</summary>
	public void OnListenerUpdated(AActor ActorListener,UAIPerceptionComponent PerceptionComponent) {}
	///<summary>called when a listener unregistered from this sense. Most often this is called due to actor&#39;s death</summary>
	public void OnListenerUnregistered(AActor ActorListener,UAIPerceptionComponent PerceptionComponent) {}
	///<summary>GetAllListenerActors</summary>
	public void GetAllListenerActors(TArray<AActor> ListenerActors) {}
	///<summary>GetAllListenerComponents</summary>
	public void GetAllListenerComponents(TArray<UAIPerceptionComponent> ListenerComponents) {}
	///<summary>called when sense&#39;s instance gets notified about new pawn that has just been spawned</summary>
	public void K2_OnNewPawn(APawn NewPawn) {}
}
