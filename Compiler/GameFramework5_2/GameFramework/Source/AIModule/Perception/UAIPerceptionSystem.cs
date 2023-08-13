namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>By design checks perception between hostile teams</summary>
[CppInclude("Perception/AIPerceptionSystem.h")]
public partial class UAIPerceptionSystem : UAISubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Senses</summary>
	public TArray<UAISense> Senses;
	///<summary>PerceptionAgingRate</summary>
	public float PerceptionAgingRate;
	///<summary>ReportEvent</summary>
	public void ReportEvent(UAISenseEvent PerceptionEvent) {}
	///<summary>ReportPerceptionEvent</summary>
	public static void ReportPerceptionEvent(UObject WorldContextObject,UAISenseEvent PerceptionEvent) {}
	///<summary>RegisterPerceptionStimuliSource</summary>
	public static bool RegisterPerceptionStimuliSource(UObject WorldContextObject,UClass Sense,AActor Target) { return default; }
	///<summary>GetSenseClassForStimulus</summary>
	public static UClass GetSenseClassForStimulus(UObject WorldContextObject,FAIStimulus Stimulus) { return default; }
	///<summary>OnPerceptionStimuliSourceEndPlay</summary>
	public void OnPerceptionStimuliSourceEndPlay(AActor Actor,EEndPlayReason EndPlayReason) {}
}
