#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An instantiated Actor that acts as a handler of a GameplayCue. Since they are instantiated, they can maintain state and tick/update every frame if necessary.</summary>
[CppInclude("GameplayCueNotify_Actor.h")]
public partial class AGameplayCueNotify_Actor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>OnOwnerDestroyed</summary>
	public  void OnOwnerDestroyed(AActor DestroyedActor) {}
	///<summary>Ends the gameplay cue: either destroying it or recycling it. You must call this manually only if you do not use bAutoDestroyOnRemove/AutoDestroyDelay</summary>
	public  void K2_EndGameplayCue() {}
	///<summary>We will auto destroy (recycle) this GameplayCueActor when the OnRemove event fires (after OnRemove is called).</summary>
	public bool bAutoDestroyOnRemove;
	///<summary>If bAutoDestroyOnRemove is true, the actor will stay alive for this many seconds before being auto destroyed.</summary>
	public float AutoDestroyDelay;
	///<summary>Warn if we have a timeline running when we cleanup this gameplay cue (we will kill the timeline either way)</summary>
	public bool WarnIfTimelineIsStillRunning;
	///<summary>Warn if we have a latent action (delay, etc) running when we cleanup this gameplay cue (we will kill the latent action either way)</summary>
	public bool WarnIfLatentActionIsStillRunning;
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
	///<summary>If true, attach this GameplayCue Actor to the target actor while it is active. Attaching is slightly more expensive than not attaching, so only enable when you need to.</summary>
	public bool bAutoAttachToOwner;
	///<summary>Does this Cue override other cues, or is it called in addition to them? E.g., If this is Damage.Physical.Slash, we wont call Damage.Physical afer we run this cue.</summary>
	public bool IsOverride;
	///<summary>Does this cue get a new instance for each instigator? For example if two instigators apply a GC to the same source, do we create two of these GameplayCue Notify actors or just one?</summary>
	public bool bUniqueInstancePerInstigator;
	///<summary>Does this cue get a new instance for each source object? For example if two source objects apply a GC to the same source, do we create two of these GameplayCue Notify actors or just one?</summary>
	public bool bUniqueInstancePerSourceObject;
	///<summary>Does this cue trigger its OnActive event if it&#39;s already been triggered?</summary>
	public bool bAllowMultipleOnActiveEvents;
	///<summary>Does this cue trigger its WhileActive event if it&#39;s already been triggered?</summary>
	public bool bAllowMultipleWhileActiveEvents;
	///<summary>How many instances of the gameplay cue to preallocate</summary>
	public int NumPreallocatedInstances;
}
