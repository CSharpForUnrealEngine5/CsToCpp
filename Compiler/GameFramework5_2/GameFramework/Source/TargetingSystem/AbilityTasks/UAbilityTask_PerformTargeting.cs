#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilityTasks/AbilityTask_PerformTargeting.h")]
public partial class UAbilityTask_PerformTargeting : UAbilityTask {
// AbilityTask_PerformTargeting
	public FTargetReadyDelegate OnTargetReady;
	public static UAbilityTask_PerformTargeting PerformTargetingRequest(UGameplayAbility OwningAbility,UTargetingPreset InTargetingPreset,bool bAllowAsync) { return default; }
	public static UAbilityTask_PerformTargeting PerformFilteringRequest(UGameplayAbility OwningAbility,UTargetingPreset TargetingPreset,TArray<AActor> InTargets,bool bAllowAsync) { return default; }
}
