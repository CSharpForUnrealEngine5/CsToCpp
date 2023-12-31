namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wait for targeting actor (spawned from parameter) to provide data. Can be set not to end upon outputting data. Can be ended by task name.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitTargetData.h")]
public partial class UAbilityTask_WaitTargetData : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>ValidData</summary>
	public FWaitTargetDataDelegate ValidData;
	///<summary>Cancelled</summary>
	public FWaitTargetDataDelegate Cancelled;
	///<summary>OnTargetDataReplicatedCallback</summary>
	public virtual void OnTargetDataReplicatedCallback(FGameplayAbilityTargetDataHandle Data,FGameplayTag ActivationTag) {}
	///<summary>OnTargetDataReplicatedCancelledCallback</summary>
	public virtual void OnTargetDataReplicatedCancelledCallback() {}
	///<summary>OnTargetDataReadyCallback</summary>
	public virtual void OnTargetDataReadyCallback(FGameplayAbilityTargetDataHandle Data) {}
	///<summary>OnTargetDataCancelledCallback</summary>
	public virtual void OnTargetDataCancelledCallback(FGameplayAbilityTargetDataHandle Data) {}
	///<summary>Spawns target actor and waits for it to return valid data or to be canceled.</summary>
	public static UAbilityTask_WaitTargetData WaitTargetData(UGameplayAbility OwningAbility,FName TaskInstanceName,EGameplayTargetingConfirmation ConfirmationType,UClass Class) { return default; }
	///<summary>Uses specified target actor and waits for it to return valid data or to be canceled.</summary>
	public static UAbilityTask_WaitTargetData WaitTargetDataUsingActor(UGameplayAbility OwningAbility,FName TaskInstanceName,EGameplayTargetingConfirmation ConfirmationType,AGameplayAbilityTargetActor TargetActor) { return default; }
	///<summary>BeginSpawningActor</summary>
	public virtual bool BeginSpawningActor(UGameplayAbility OwningAbility,UClass Class,AGameplayAbilityTargetActor SpawnedActor) { return default; }
	///<summary>FinishSpawningActor</summary>
	public virtual void FinishSpawningActor(UGameplayAbility OwningAbility,AGameplayAbilityTargetActor SpawnedActor) {}
	///<summary>TargetClass</summary>
	public UClass TargetClass;
	///<summary>The TargetActor that we spawned</summary>
	public AGameplayAbilityTargetActor TargetActor;
}
