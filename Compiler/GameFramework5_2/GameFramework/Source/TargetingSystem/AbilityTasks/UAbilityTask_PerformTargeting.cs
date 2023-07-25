#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilityTasks/AbilityTask_PerformTargeting.h")]
public partial class UAbilityTask_PerformTargeting : UAbilityTask {
// AbilityTask_PerformTargeting
	public FTargetReadyDelegate OnTargetReady;
	public UObject PerformTargetingRequest(UObject OwningAbility,UObject InTargetingPreset,bool bAllowAsync) { return default; }
	public UObject PerformFilteringRequest(UObject OwningAbility,UObject TargetingPreset,TArray<UObject> InTargets,bool bAllowAsync) { return default; }
}
