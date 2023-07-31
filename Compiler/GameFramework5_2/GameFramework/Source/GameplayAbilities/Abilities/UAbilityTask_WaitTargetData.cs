#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wait for targeting actor (spawned from parameter) to provide data. Can be set not to end upon outputting data. Can be ended by task name.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitTargetData.h")]
public partial class UAbilityTask_WaitTargetData : UAbilityTask {
	///<summary>ValidData</summary>
	public FWaitTargetDataDelegate ValidData;
	///<summary>Cancelled</summary>
	public FWaitTargetDataDelegate Cancelled;
	///<summary>OnTargetDataReplicatedCallback</summary>
	public  void OnTargetDataReplicatedCallback(FGameplayAbilityTargetDataHandle Data,FGameplayTag ActivationTag) {}
	///<summary>OnTargetDataReplicatedCancelledCallback</summary>
	public  void OnTargetDataReplicatedCancelledCallback() {}
	///<summary>OnTargetDataReadyCallback</summary>
	public  void OnTargetDataReadyCallback(FGameplayAbilityTargetDataHandle Data) {}
	///<summary>OnTargetDataCancelledCallback</summary>
	public  void OnTargetDataCancelledCallback(FGameplayAbilityTargetDataHandle Data) {}
	///<summary>Spawns target actor and waits for it to return valid data or to be canceled.</summary>
	public static UAbilityTask_WaitTargetData WaitTargetData(UGameplayAbility OwningAbility,string TaskInstanceName,EGameplayTargetingConfirmation ConfirmationType,UClass Class) { return default; }
	///<summary>Uses specified target actor and waits for it to return valid data or to be canceled.</summary>
	public static UAbilityTask_WaitTargetData WaitTargetDataUsingActor(UGameplayAbility OwningAbility,string TaskInstanceName,EGameplayTargetingConfirmation ConfirmationType,AGameplayAbilityTargetActor TargetActor) { return default; }
	///<summary>BeginSpawningActor</summary>
	public  bool BeginSpawningActor(UGameplayAbility OwningAbility,UClass Class,AGameplayAbilityTargetActor SpawnedActor) { return default; }
	///<summary>FinishSpawningActor</summary>
	public  void FinishSpawningActor(UGameplayAbility OwningAbility,AGameplayAbilityTargetActor SpawnedActor) {}
	///<summary>TargetClass</summary>
	public UClass TargetClass;
	///<summary>The TargetActor that we spawned</summary>
	public AGameplayAbilityTargetActor TargetActor;
}
