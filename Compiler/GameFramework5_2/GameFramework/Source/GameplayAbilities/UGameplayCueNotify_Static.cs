#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A non instantiated UObject that acts as a handler for a GameplayCue. These are useful for one-off &quot;burst&quot; effects.</summary>
[CppInclude("GameplayCueNotify_Static.h")]
public partial class UGameplayCueNotify_Static : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Generic Event Graph event that will get called for every event type</summary>
	public  void K2_HandleGameplayCue(AActor MyTarget,EGameplayCueEvent EventType,FGameplayCueParameters Parameters) {}
	///<summary>Called when a GameplayCue is executed, this is used for instant effects or periodic ticks</summary>
	public  bool OnExecute(AActor MyTarget,FGameplayCueParameters Parameters) { return default; }
	///<summary>Called when a GameplayCue with duration is first activated, this will only be called if the client witnessed the activation</summary>
	public  bool OnActive(AActor MyTarget,FGameplayCueParameters Parameters) { return default; }
	///<summary>Called when a GameplayCue with duration is first seen as active, even if it wasn&#39;t actually just applied (Join in progress, etc)</summary>
	public  bool WhileActive(AActor MyTarget,FGameplayCueParameters Parameters) { return default; }
	///<summary>Called when a GameplayCue with duration is removed</summary>
	public  bool OnRemove(AActor MyTarget,FGameplayCueParameters Parameters) { return default; }
	///<summary>Tag this notify is activated by</summary>
	public FGameplayTag GameplayCueTag;
	///<summary>Mirrors GameplayCueTag in order to be asset registry searchable</summary>
	public string GameplayCueName;
	///<summary>Does this Cue override other cues, or is it called in addition to them? E.g., If this is Damage.Physical.Slash, we wont call Damage.Physical afer we run this cue.</summary>
	public bool IsOverride;
}
