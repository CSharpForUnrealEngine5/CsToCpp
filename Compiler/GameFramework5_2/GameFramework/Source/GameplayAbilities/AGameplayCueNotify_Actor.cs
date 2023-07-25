#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotify_Actor.h")]
///<summary>An instantiated Actor that acts as a handler of a GameplayCue. Since they are instantiated, they can maintain state and tick/update every frame if necessary.</summary>
public partial class AGameplayCueNotify_Actor : AActor {
// GameplayCueNotify_Actor
	public void OnOwnerDestroyed(UObject DestroyedActor) {}
	public void K2_EndGameplayCue() {}
	public bool bAutoDestroyOnRemove;
	public float AutoDestroyDelay;
	public bool WarnIfTimelineIsStillRunning;
	public bool WarnIfLatentActionIsStillRunning;
	public void K2_HandleGameplayCue(UObject MyTarget,EGameplayCueEvent EventType,FGameplayCueParameters Parameters) {}
	public bool OnExecute(UObject MyTarget,FGameplayCueParameters Parameters) { return default; }
	public bool OnActive(UObject MyTarget,FGameplayCueParameters Parameters) { return default; }
	public bool WhileActive(UObject MyTarget,FGameplayCueParameters Parameters) { return default; }
	public bool OnRemove(UObject MyTarget,FGameplayCueParameters Parameters) { return default; }
	public FGameplayTag GameplayCueTag;
	public string GameplayCueName;
	public bool bAutoAttachToOwner;
	public bool IsOverride;
	public bool bUniqueInstancePerInstigator;
	public bool bUniqueInstancePerSourceObject;
	public bool bAllowMultipleOnActiveEvents;
	public bool bAllowMultipleWhileActiveEvents;
	public int NumPreallocatedInstances;
}
