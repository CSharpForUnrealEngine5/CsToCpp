#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AIPerceptionComponent is used to register as stimuli listener in AIPerceptionSystem</summary>
[CppInclude("Perception/AIPerceptionComponent.h")]
public partial class UAIPerceptionComponent : UActorComponent {
	///<summary>SensesConfig</summary>
	public TArray<UAISenseConfig> SensesConfig;
	///<summary>Indicated sense that takes precedence over other senses when determining sensed actor&#39;s location.</summary>
	public UClass DominantSense;
	///<summary>AIOwner</summary>
	public AAIController AIOwner;
	///<summary>OnOwnerEndPlay</summary>
	public  void OnOwnerEndPlay(AActor Actor,EEndPlayReason EndPlayReason) {}
	///<summary>Notifies AIPerceptionSystem to update properties for this &quot;stimuli listener&quot;</summary>
	public  void RequestStimuliListenerUpdate() {}
	///<summary>basically cleans up PerceptualData, resulting in loss of all previous perception</summary>
	public  void ForgetAll() {}
	///<summary>blueprint interface</summary>
	public  void GetPerceivedHostileActors(TArray<AActor> OutActors) {}
	///<summary>GetPerceivedHostileActorsBySense</summary>
	public  void GetPerceivedHostileActorsBySense(UClass SenseToUse,TArray<AActor> OutActors) {}
	///<summary>If SenseToUse is none all actors currently perceived in any way will get fetched</summary>
	public  void GetCurrentlyPerceivedActors(UClass SenseToUse,TArray<AActor> OutActors) {}
	///<summary>If SenseToUse is none all actors ever perceived in any way (and not forgotten yet) will get fetched</summary>
	public  void GetKnownPerceivedActors(UClass SenseToUse,TArray<AActor> OutActors) {}
	///<summary>GetPerceivedActors</summary>
	public  void GetPerceivedActors(UClass SenseToUse,TArray<AActor> OutActors) {}
	///<summary>Retrieves whatever has been sensed about given actor</summary>
	public  bool GetActorsPerception(AActor Actor,FActorPerceptionBlueprintInfo Info) { return default; }
	///<summary>Note that this works only if given sense has been already configured for</summary>
	public  void SetSenseEnabled(UClass SenseClass,bool bEnable) {}
	///<summary>Might want to move these to special &quot;BP_AIPerceptionComponent&quot;</summary>
	public FPerceptionUpdatedDelegate OnPerceptionUpdated;
	///<summary>Notifies all bound delegates that the perception info has been forgotten for a given target.</summary>
	public FActorPerceptionForgetUpdatedDelegate OnTargetPerceptionForgotten;
	///<summary>Notifies all bound objects that perception info has been updated for a given target.</summary>
	public FActorPerceptionUpdatedDelegate OnTargetPerceptionUpdated;
	///<summary>Notifies all bound objects that perception info has been updated for a given target.</summary>
	public FActorPerceptionInfoUpdatedDelegate OnTargetPerceptionInfoUpdated;
}
