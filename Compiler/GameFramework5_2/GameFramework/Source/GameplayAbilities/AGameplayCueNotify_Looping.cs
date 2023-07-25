#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotify_Looping.h")]
///<summary>AGameplayCueNotify_Looping</summary>
public partial class AGameplayCueNotify_Looping : AGameplayCueNotify_Actor {
// GameplayCueNotify_Looping
	public void OnApplication(UObject Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	public void OnLoopingStart(UObject Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	public void OnRecurring(UObject Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	public void OnRemoval(UObject Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	public FGameplayCueNotify_SpawnCondition DefaultSpawnCondition;
	public FGameplayCueNotify_PlacementInfo DefaultPlacementInfo;
	public FGameplayCueNotify_BurstEffects ApplicationEffects;
	public FGameplayCueNotify_SpawnResult ApplicationSpawnResults;
	public FGameplayCueNotify_LoopingEffects LoopingEffects;
	public FGameplayCueNotify_SpawnResult LoopingSpawnResults;
	public FGameplayCueNotify_BurstEffects RecurringEffects;
	public FGameplayCueNotify_SpawnResult RecurringSpawnResults;
	public FGameplayCueNotify_BurstEffects RemovalEffects;
	public FGameplayCueNotify_SpawnResult RemovalSpawnResults;
}
