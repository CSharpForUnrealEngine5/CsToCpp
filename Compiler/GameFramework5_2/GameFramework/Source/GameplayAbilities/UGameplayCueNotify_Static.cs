#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotify_Static.h")]
///<summary>A non instantiated UObject that acts as a handler for a GameplayCue. These are useful for one-off "burst" effects.</summary>
public partial class UGameplayCueNotify_Static : UObject {
// GameplayCueNotify_Static
	public void K2_HandleGameplayCue(UObject MyTarget,EGameplayCueEvent EventType,FGameplayCueParameters Parameters) {}
	public bool OnExecute(UObject MyTarget,FGameplayCueParameters Parameters) { return default; }
	public bool OnActive(UObject MyTarget,FGameplayCueParameters Parameters) { return default; }
	public bool WhileActive(UObject MyTarget,FGameplayCueParameters Parameters) { return default; }
	public bool OnRemove(UObject MyTarget,FGameplayCueParameters Parameters) { return default; }
	public FGameplayTag GameplayCueTag;
	public string GameplayCueName;
	public bool IsOverride;
}
