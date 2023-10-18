namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilityTasks/AbilityTask_PerformTargeting.h")]
public partial class UAbilityTask_PerformTargeting : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the targeting request has been completed and results are ready</summary>
	public FTargetReadyDelegate OnTargetReady;
	///<summary>Performs a targeting request based on a Targeting Preset from a GameplayAbility</summary>
	public static UAbilityTask_PerformTargeting PerformTargetingRequest(UGameplayAbility OwningAbility,UTargetingPreset InTargetingPreset,bool bAllowAsync) { return default; }
	///<summary>Performs a target filtering request based on a Targeting Preset from a GameplayAbility</summary>
	public static UAbilityTask_PerformTargeting PerformFilteringRequest(UGameplayAbility OwningAbility,UTargetingPreset TargetingPreset,TArray<AActor> InTargets,bool bAllowAsync) { return default; }
}
