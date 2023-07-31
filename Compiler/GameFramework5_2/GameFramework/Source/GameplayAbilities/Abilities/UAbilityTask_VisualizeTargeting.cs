#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_VisualizeTargeting.h")]
public partial class UAbilityTask_VisualizeTargeting : UAbilityTask {
	///<summary>TimeElapsed</summary>
	public FVisualizeTargetingDelegate TimeElapsed;
	///<summary>Spawns target actor and uses it for visualization.</summary>
	public static UAbilityTask_VisualizeTargeting VisualizeTargeting(UGameplayAbility OwningAbility,UClass Class,string TaskInstanceName,float Duration/*=-1.0f*/) { return default; }
	///<summary>Visualize target using a specified target actor.</summary>
	public static UAbilityTask_VisualizeTargeting VisualizeTargetingUsingActor(UGameplayAbility OwningAbility,AGameplayAbilityTargetActor TargetActor,string TaskInstanceName,float Duration/*=-1.0f*/) { return default; }
	///<summary>BeginSpawningActor</summary>
	public  bool BeginSpawningActor(UGameplayAbility OwningAbility,UClass Class,AGameplayAbilityTargetActor SpawnedActor) { return default; }
	///<summary>FinishSpawningActor</summary>
	public  void FinishSpawningActor(UGameplayAbility OwningAbility,AGameplayAbilityTargetActor SpawnedActor) {}
}
