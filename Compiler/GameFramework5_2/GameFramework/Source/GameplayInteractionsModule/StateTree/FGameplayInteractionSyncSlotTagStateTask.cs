#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to monitor existence of a Gameplay Tag on the specified Smart Object slot.</summary>
[CppInclude("StateTree/GameplayInteractionSyncSlotTagStateTask.h")]
public partial struct FGameplayInteractionSyncSlotTagStateTask {
	public FGameplayTag TagToMonitor;
	public FGameplayTag BreakEventTag;
}
