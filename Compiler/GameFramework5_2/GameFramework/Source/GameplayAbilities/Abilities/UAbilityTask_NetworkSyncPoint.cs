#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task for providing a generic sync point for client server (one can wait for a signal from the other)</summary>
[CppInclude("Abilities/Tasks/AbilityTask_NetworkSyncPoint.h")]
public partial class UAbilityTask_NetworkSyncPoint : UAbilityTask {
	///<summary>OnSync</summary>
	public FNetworkSyncDelegate OnSync;
	///<summary>OnSignalCallback</summary>
	public  void OnSignalCallback() {}
	///<summary>Synchronize execution flow between Client and Server. Depending on SyncType, the Client and Server will wait for the other to reach this node or another WaitNetSync node in the ability before continuing execution.</summary>
	public static UAbilityTask_NetworkSyncPoint WaitNetSync(UGameplayAbility OwningAbility,EAbilityTaskNetSyncType SyncType) { return default; }
}
