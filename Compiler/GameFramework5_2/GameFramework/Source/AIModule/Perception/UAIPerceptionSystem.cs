#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionSystem.h")]
///<summary>By design checks perception between hostile teams</summary>
public partial class UAIPerceptionSystem : UAISubsystem {
// AIPerceptionSystem
	public TArray<UAISense> Senses;
	public float PerceptionAgingRate;
	public  void ReportEvent(UAISenseEvent PerceptionEvent) {}
	public static void ReportPerceptionEvent(UObject WorldContextObject,UAISenseEvent PerceptionEvent) {}
	public static bool RegisterPerceptionStimuliSource(UObject WorldContextObject,UClass Sense,AActor Target) { return default; }
	public static UClass GetSenseClassForStimulus(UObject WorldContextObject,FAIStimulus Stimulus) { return default; }
	public  void OnPerceptionStimuliSourceEndPlay(AActor Actor,EEndPlayReason EndPlayReason) {}
}
