#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitTargetData.h")]
///<summary>Wait for targeting actor (spawned from parameter) to provide data. Can be set not to end upon outputting data. Can be ended by task name.</summary>
public partial class UAbilityTask_WaitTargetData : UAbilityTask {
// AbilityTask_WaitTargetData
	public FWaitTargetDataDelegate ValidData;
	public FWaitTargetDataDelegate Cancelled;
	public void OnTargetDataReplicatedCallback(FGameplayAbilityTargetDataHandle Data,FGameplayTag ActivationTag) {}
	public void OnTargetDataReplicatedCancelledCallback() {}
	public void OnTargetDataReadyCallback(FGameplayAbilityTargetDataHandle Data) {}
	public void OnTargetDataCancelledCallback(FGameplayAbilityTargetDataHandle Data) {}
	public UObject WaitTargetData(UObject OwningAbility,string TaskInstanceName,byte ConfirmationType,UClass Class) { return default; }
	public UObject WaitTargetDataUsingActor(UObject OwningAbility,string TaskInstanceName,byte ConfirmationType,UObject TargetActor) { return default; }
	public bool BeginSpawningActor(UObject OwningAbility,UClass Class,UObject SpawnedActor) { return default; }
	public void FinishSpawningActor(UObject OwningAbility,UObject SpawnedActor) {}
	public UClass TargetClass;
	public AGameplayAbilityTargetActor TargetActor;
}
