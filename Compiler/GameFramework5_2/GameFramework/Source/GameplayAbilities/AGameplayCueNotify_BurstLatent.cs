namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AGameplayCueNotify_BurstLatent</summary>
[CppInclude("GameplayCueNotify_BurstLatent.h")]
public partial class AGameplayCueNotify_BurstLatent : AGameplayCueNotify_Actor {
	public static UClass StaticClass() {return default;}
	///<summary>OnBurst</summary>
	public void OnBurst(AActor Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	///<summary>Default condition to check before spawning anything.  Applies for all spawns unless overridden.</summary>
	public FGameplayCueNotify_SpawnCondition DefaultSpawnCondition;
	///<summary>Default placement rules.  Applies for all spawns unless overridden.</summary>
	public FGameplayCueNotify_PlacementInfo DefaultPlacementInfo;
	///<summary>List of effects to spawn on burst.</summary>
	public FGameplayCueNotify_BurstEffects BurstEffects;
	///<summary>Results of spawned burst effects.</summary>
	public FGameplayCueNotify_SpawnResult BurstSpawnResults;
}
