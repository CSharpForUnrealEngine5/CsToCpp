#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionComponent.h")]
///<summary>AIPerceptionComponent is used to register as stimuli listener in AIPerceptionSystem</summary>
public partial class UAIPerceptionComponent : UActorComponent {
// AIPerceptionComponent
	public TArray<UAISenseConfig> SensesConfig;
	public UClass DominantSense;
	public AAIController AIOwner;
	public void OnOwnerEndPlay(UObject Actor,EEndPlayReason EndPlayReason) {}
	public void RequestStimuliListenerUpdate() {}
	public void ForgetAll() {}
	public void GetPerceivedHostileActors(TArray<UObject> OutActors) {}
	public void GetPerceivedHostileActorsBySense(UClass SenseToUse,TArray<UObject> OutActors) {}
	public void GetCurrentlyPerceivedActors(UClass SenseToUse,TArray<UObject> OutActors) {}
	public void GetKnownPerceivedActors(UClass SenseToUse,TArray<UObject> OutActors) {}
	public void GetPerceivedActors(UClass SenseToUse,TArray<UObject> OutActors) {}
	public bool GetActorsPerception(UObject Actor,FActorPerceptionBlueprintInfo Info) { return default; }
	public void SetSenseEnabled(UClass SenseClass,bool bEnable) {}
	public FPerceptionUpdatedDelegate OnPerceptionUpdated;
	public FActorPerceptionForgetUpdatedDelegate OnTargetPerceptionForgotten;
	public FActorPerceptionUpdatedDelegate OnTargetPerceptionUpdated;
	public FActorPerceptionInfoUpdatedDelegate OnTargetPerceptionInfoUpdated;
}
