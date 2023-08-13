namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ActorComponent for running Mock Ability Simulation for CharacterMotion example</summary>
[CppInclude("MockCharacterAbilitySimulation.h")]
public partial class UMockCharacterAbilityComponent : UCharacterMotionComponent {
	public static UClass StaticClass() {return default;}
	///<summary>// NetSimCues</summary>
	public void FMockCharacterAbilityNotifyStateChange(bool bNewStateValue) {}
	///<summary>Notifies when Sprint state changes</summary>
	public FMockCharacterAbilityNotifyStateChange OnSprintStateChange;
	///<summary>Notifies when Dash state changes</summary>
	public FMockCharacterAbilityNotifyStateChange OnDashStateChange;
	///<summary>Notifies when Blink Changes</summary>
	public FMockCharacterAbilityNotifyStateChange OnBlinkStateChange;
	///<summary>Notifies when Jump Changes</summary>
	public FMockCharacterAbilityNotifyStateChange OnJumpStateChange;
	///<summary>Are we currently in the sprinting state</summary>
	public bool IsSprinting() { return default; }
	///<summary>Are we currently in the dashing state</summary>
	public bool IsDashing() { return default; }
	///<summary>Are we currently in the blinking (startup) state</summary>
	public bool IsBlinking() { return default; }
	///<summary>Are we currently in the jumping state</summary>
	public bool IsJumping() { return default; }
	///<summary>Blueprint assignable events for blinking. This allows the user/blueprint to implement rollback-able events</summary>
	public void FMockCharacterAbilityBlinkCueEvent(FVector DestinationLocation,int RandomValue,float ElapsedTimeSeconds) {}
	///<summary>OnBlinkActivateEvent</summary>
	public FMockCharacterAbilityBlinkCueEvent OnBlinkActivateEvent;
	///<summary>FMockCharacterAbilityBlinkCueRollback</summary>
	public void FMockCharacterAbilityBlinkCueRollback() {}
	///<summary>OnBlinkActivateEventRollback</summary>
	public FMockCharacterAbilityBlinkCueRollback OnBlinkActivateEventRollback;
	///<summary>GetBlinkWarmupTimeSeconds</summary>
	public float GetBlinkWarmupTimeSeconds() { return default; }
	///<summary>GetStamina</summary>
	public float GetStamina() { return default; }
	///<summary>GetMaxStamina</summary>
	public float GetMaxStamina() { return default; }
}
