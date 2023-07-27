#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockCharacterAbilitySimulation.h")]
///<summary>ActorComponent for running Mock Ability Simulation for CharacterMotion example</summary>
public partial class UMockCharacterAbilityComponent : UCharacterMotionComponent {
// MockCharacterAbilityComponent
	public  void FMockCharacterAbilityNotifyStateChange(bool bNewStateValue) {}
	public FMockCharacterAbilityNotifyStateChange OnSprintStateChange;
	public FMockCharacterAbilityNotifyStateChange OnDashStateChange;
	public FMockCharacterAbilityNotifyStateChange OnBlinkStateChange;
	public FMockCharacterAbilityNotifyStateChange OnJumpStateChange;
	public  bool IsSprinting() { return default; }
	public  bool IsDashing() { return default; }
	public  bool IsBlinking() { return default; }
	public  bool IsJumping() { return default; }
	public  void FMockCharacterAbilityBlinkCueEvent(FVector DestinationLocation,int RandomValue,float ElapsedTimeSeconds) {}
	public FMockCharacterAbilityBlinkCueEvent OnBlinkActivateEvent;
	public  void FMockCharacterAbilityBlinkCueRollback() {}
	public FMockCharacterAbilityBlinkCueRollback OnBlinkActivateEventRollback;
	public  float GetBlinkWarmupTimeSeconds() { return default; }
	public  float GetStamina() { return default; }
	public  float GetMaxStamina() { return default; }
}
