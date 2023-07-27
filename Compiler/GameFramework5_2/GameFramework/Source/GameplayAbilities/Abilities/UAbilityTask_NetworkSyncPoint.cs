#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_NetworkSyncPoint.h")]
///<summary>Task for providing a generic sync point for client server (one can wait for a signal from the other)</summary>
public partial class UAbilityTask_NetworkSyncPoint : UAbilityTask {
// AbilityTask_NetworkSyncPoint
	public FNetworkSyncDelegate OnSync;
	public  void OnSignalCallback() {}
	public static UAbilityTask_NetworkSyncPoint WaitNetSync(UGameplayAbility OwningAbility,EAbilityTaskNetSyncType SyncType) { return default; }
}
