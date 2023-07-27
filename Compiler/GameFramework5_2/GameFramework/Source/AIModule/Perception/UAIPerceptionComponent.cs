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
	public  void OnOwnerEndPlay(AActor Actor,EEndPlayReason EndPlayReason) {}
	public  void RequestStimuliListenerUpdate() {}
	public  void ForgetAll() {}
	public  void GetPerceivedHostileActors(TArray<AActor> OutActors) {}
	public  void GetPerceivedHostileActorsBySense(UClass SenseToUse,TArray<AActor> OutActors) {}
	public  void GetCurrentlyPerceivedActors(UClass SenseToUse,TArray<AActor> OutActors) {}
	public  void GetKnownPerceivedActors(UClass SenseToUse,TArray<AActor> OutActors) {}
	public  void GetPerceivedActors(UClass SenseToUse,TArray<AActor> OutActors) {}
	public  bool GetActorsPerception(AActor Actor,FActorPerceptionBlueprintInfo Info) { return default; }
	public  void SetSenseEnabled(UClass SenseClass,bool bEnable) {}
	public FPerceptionUpdatedDelegate OnPerceptionUpdated;
	public FActorPerceptionForgetUpdatedDelegate OnTargetPerceptionForgotten;
	public FActorPerceptionUpdatedDelegate OnTargetPerceptionUpdated;
	public FActorPerceptionInfoUpdatedDelegate OnTargetPerceptionInfoUpdated;
}
