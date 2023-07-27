#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitMovementModeChange.h")]
public partial class UAbilityTask_WaitMovementModeChange : UAbilityTask {
// AbilityTask_WaitMovementModeChange
	public FMovementModeChangedDelegate OnChange;
	public  void OnMovementModeChange(ACharacter Character,EMovementMode PrevMovementMode,byte PreviousCustomMode) {}
	public static UAbilityTask_WaitMovementModeChange CreateWaitMovementModeChange(UGameplayAbility OwningAbility,EMovementMode NewMode) { return default; }
}
