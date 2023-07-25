#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionSystem.h")]
///<summary>By design checks perception between hostile teams</summary>
public partial class UAIPerceptionSystem : UAISubsystem {
// AIPerceptionSystem
	public TArray<UAISense> Senses;
	public float PerceptionAgingRate;
	public void ReportEvent(UObject PerceptionEvent) {}
	public void ReportPerceptionEvent(UObject WorldContextObject,UObject PerceptionEvent) {}
	public bool RegisterPerceptionStimuliSource(UObject WorldContextObject,UClass Sense,UObject Target) { return default; }
	public UClass GetSenseClassForStimulus(UObject WorldContextObject,FAIStimulus Stimulus) { return default; }
	public void OnPerceptionStimuliSourceEndPlay(UObject Actor,EEndPlayReason EndPlayReason) {}
}
