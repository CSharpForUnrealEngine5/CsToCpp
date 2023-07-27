#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_VisualizeTargeting.h")]
public partial class UAbilityTask_VisualizeTargeting : UAbilityTask {
// AbilityTask_VisualizeTargeting
	public FVisualizeTargetingDelegate TimeElapsed;
	public static UAbilityTask_VisualizeTargeting VisualizeTargeting(UGameplayAbility OwningAbility,UClass Class,string TaskInstanceName,float Duration/*=-1.0f*/) { return default; }
	public static UAbilityTask_VisualizeTargeting VisualizeTargetingUsingActor(UGameplayAbility OwningAbility,AGameplayAbilityTargetActor TargetActor,string TaskInstanceName,float Duration/*=-1.0f*/) { return default; }
	public  bool BeginSpawningActor(UGameplayAbility OwningAbility,UClass Class,AGameplayAbilityTargetActor SpawnedActor) { return default; }
	public  void FinishSpawningActor(UGameplayAbility OwningAbility,AGameplayAbilityTargetActor SpawnedActor) {}
}
