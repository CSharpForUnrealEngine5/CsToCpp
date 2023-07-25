#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitMovementModeChange.h")]
public partial class UAbilityTask_WaitMovementModeChange : UAbilityTask {
// AbilityTask_WaitMovementModeChange
	public FMovementModeChangedDelegate OnChange;
	public void OnMovementModeChange(UObject Character,EMovementMode PrevMovementMode,byte PreviousCustomMode) {}
	public UObject CreateWaitMovementModeChange(UObject OwningAbility,EMovementMode NewMode) { return default; }
}
