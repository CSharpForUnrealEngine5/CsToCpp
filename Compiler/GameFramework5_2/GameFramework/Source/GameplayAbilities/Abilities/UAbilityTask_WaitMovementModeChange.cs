#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitMovementModeChange.h")]
public partial class UAbilityTask_WaitMovementModeChange : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnChange</summary>
	public FMovementModeChangedDelegate OnChange;
	///<summary>OnMovementModeChange</summary>
	public  void OnMovementModeChange(ACharacter Character,EMovementMode PrevMovementMode,byte PreviousCustomMode) {}
	///<summary>Wait until movement mode changes (E.g., landing)</summary>
	public static UAbilityTask_WaitMovementModeChange CreateWaitMovementModeChange(UGameplayAbility OwningAbility,EMovementMode NewMode) { return default; }
}
