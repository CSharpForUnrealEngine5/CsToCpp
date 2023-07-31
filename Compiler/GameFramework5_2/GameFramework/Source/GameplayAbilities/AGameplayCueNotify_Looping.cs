#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AGameplayCueNotify_Looping</summary>
[CppInclude("GameplayCueNotify_Looping.h")]
public partial class AGameplayCueNotify_Looping : AGameplayCueNotify_Actor {
	///<summary>OnApplication</summary>
	public  void OnApplication(AActor Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	///<summary>OnLoopingStart</summary>
	public  void OnLoopingStart(AActor Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	///<summary>OnRecurring</summary>
	public  void OnRecurring(AActor Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	///<summary>OnRemoval</summary>
	public  void OnRemoval(AActor Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	///<summary>Default condition to check before spawning anything.  Applies for all spawns unless overridden.</summary>
	public FGameplayCueNotify_SpawnCondition DefaultSpawnCondition;
	///<summary>Default placement rules.  Applies for all spawns unless overridden.</summary>
	public FGameplayCueNotify_PlacementInfo DefaultPlacementInfo;
	///<summary>List of effects to spawn on application.  These should not be looping effects!</summary>
	public FGameplayCueNotify_BurstEffects ApplicationEffects;
	///<summary>Results of spawned application effects.</summary>
	public FGameplayCueNotify_SpawnResult ApplicationSpawnResults;
	///<summary>List of effects to spawn on loop start.</summary>
	public FGameplayCueNotify_LoopingEffects LoopingEffects;
	///<summary>Results of spawned looping effects.</summary>
	public FGameplayCueNotify_SpawnResult LoopingSpawnResults;
	///<summary>List of effects to spawn for a recurring gameplay effect (e.g. each time a DOT ticks).  These should not be looping effects!</summary>
	public FGameplayCueNotify_BurstEffects RecurringEffects;
	///<summary>Results of spawned recurring effects.</summary>
	public FGameplayCueNotify_SpawnResult RecurringSpawnResults;
	///<summary>List of effects to spawn on removal.  These should not be looping effects!</summary>
	public FGameplayCueNotify_BurstEffects RemovalEffects;
	///<summary>Results of spawned removal effects.</summary>
	public FGameplayCueNotify_SpawnResult RemovalSpawnResults;
}
