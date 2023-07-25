#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotify_BurstLatent.h")]
///<summary>AGameplayCueNotify_BurstLatent</summary>
public partial class AGameplayCueNotify_BurstLatent : AGameplayCueNotify_Actor {
// GameplayCueNotify_BurstLatent
	public void OnBurst(UObject Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	public FGameplayCueNotify_SpawnCondition DefaultSpawnCondition;
	public FGameplayCueNotify_PlacementInfo DefaultPlacementInfo;
	public FGameplayCueNotify_BurstEffects BurstEffects;
	public FGameplayCueNotify_SpawnResult BurstSpawnResults;
}
