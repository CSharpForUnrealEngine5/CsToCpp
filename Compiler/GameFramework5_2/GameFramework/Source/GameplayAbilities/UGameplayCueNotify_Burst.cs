#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGameplayCueNotify_Burst</summary>
[CppInclude("GameplayCueNotify_Burst.h")]
public partial class UGameplayCueNotify_Burst : UGameplayCueNotify_Static {
	///<summary>OnBurst</summary>
	public  void OnBurst(AActor Target,FGameplayCueParameters Parameters,FGameplayCueNotify_SpawnResult SpawnResults) {}
	///<summary>Default condition to check before spawning anything.  Applies for all spawns unless overridden.</summary>
	public FGameplayCueNotify_SpawnCondition DefaultSpawnCondition;
	///<summary>Default placement rules.  Applies for all spawns unless overridden.</summary>
	public FGameplayCueNotify_PlacementInfo DefaultPlacementInfo;
	///<summary>List of effects to spawn on burst.</summary>
	public FGameplayCueNotify_BurstEffects BurstEffects;
}
