#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotify_Burst.h")]
///<summary>UGameplayCueNotify_Burst</summary>
public partial class UGameplayCueNotify_Burst : UGameplayCueNotify_Static {
// GameplayCueNotify_Burst
	public  void OnBurst(AActor Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	public FGameplayCueNotify_SpawnCondition DefaultSpawnCondition;
	public FGameplayCueNotify_PlacementInfo DefaultPlacementInfo;
	public FGameplayCueNotify_BurstEffects BurstEffects;
}
