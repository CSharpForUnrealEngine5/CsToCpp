#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotify_Static.h")]
///<summary>A non instantiated UObject that acts as a handler for a GameplayCue. These are useful for one-off "burst" effects.</summary>
public partial class UGameplayCueNotify_Static : UObject {
// GameplayCueNotify_Static
	public  void K2_HandleGameplayCue(AActor MyTarget,EGameplayCueEvent EventType,FGameplayCueParameters Parameters) {}
	public  bool OnExecute(AActor MyTarget,FGameplayCueParameters Parameters) { return default; }
	public  bool OnActive(AActor MyTarget,FGameplayCueParameters Parameters) { return default; }
	public  bool WhileActive(AActor MyTarget,FGameplayCueParameters Parameters) { return default; }
	public  bool OnRemove(AActor MyTarget,FGameplayCueParameters Parameters) { return default; }
	public FGameplayTag GameplayCueTag;
	public string GameplayCueName;
	public bool IsOverride;
}
