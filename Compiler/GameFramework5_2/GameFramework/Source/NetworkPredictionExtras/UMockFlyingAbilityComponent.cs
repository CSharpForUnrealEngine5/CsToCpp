#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ActorComponent for running Mock Ability Simulation</summary>
[CppInclude("MockAbilitySimulation.h")]
public partial class UMockFlyingAbilityComponent : UFlyingMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Ability State and Notifications</summary>
	public  void FMockAbilityNotifyStateChange(bool bNewStateValue) {}
	///<summary>Notifies when Sprint state changes</summary>
	public FMockAbilityNotifyStateChange OnSprintStateChange;
	///<summary>Notifies when Dash state changes</summary>
	public FMockAbilityNotifyStateChange OnDashStateChange;
	///<summary>Notifies when Blink Changes</summary>
	public FMockAbilityNotifyStateChange OnBlinkStateChange;
	///<summary>Are we currently in the sprinting state</summary>
	public  bool IsSprinting() { return default; }
	///<summary>Are we currently in the dashing state</summary>
	public  bool IsDashing() { return default; }
	///<summary>Are we currently in the blinking (startup) state</summary>
	public  bool IsBlinking() { return default; }
	///<summary>Blueprint assignable events for blinking. THis allows the user/blueprint to implement rollback-able events</summary>
	public  void FMockAbilityBlinkCueEvent(FVector DestinationLocation,int RandomValue,float ElapsedTimeSeconds) {}
	///<summary>OnBlinkActivateEvent</summary>
	public FMockAbilityBlinkCueEvent OnBlinkActivateEvent;
	///<summary>FMockAbilityBlinkCueRollback</summary>
	public  void FMockAbilityBlinkCueRollback() {}
	///<summary>OnBlinkActivateEventRollback</summary>
	public FMockAbilityBlinkCueRollback OnBlinkActivateEventRollback;
	///<summary>FMockAbilityPhysicsGunFireEvent</summary>
	public  void FMockAbilityPhysicsGunFireEvent(FVector Start,FVector End,bool bHasCooldown,TArray<FVector_NetQuantize100> HitLocations,float ElapsedTimeSeconds) {}
	///<summary>OnPhysicsGunFirEvent</summary>
	public FMockAbilityPhysicsGunFireEvent OnPhysicsGunFirEvent;
	///<summary>GetBlinkWarmupTimeSeconds</summary>
	public  float GetBlinkWarmupTimeSeconds() { return default; }
	///<summary>GetStamina</summary>
	public  float GetStamina() { return default; }
	///<summary>GetMaxStamina</summary>
	public  float GetMaxStamina() { return default; }
}
