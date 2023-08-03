#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ActorComponent for running MockPhysicsSimulation</summary>
[CppInclude("MockPhysicsComponent.h")]
public partial class UMockPhysicsComponent : UBaseMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Next local InputCmd that will be submitted. This is just one way to do it.</summary>
	public FMockPhysicsInputCmd PendingInputCmd;
	///<summary>Assignable delegates chosen so that owning actor can implement in BPs. May not be the best choice for all cases.</summary>
	public  void FPhysicsJumpCueEvent(FVector Location,float ElapsedTimeSeconds) {}
	///<summary>OnJumpActivatedEvent</summary>
	public FPhysicsJumpCueEvent OnJumpActivatedEvent;
	///<summary>FPhysicsChargeCueEvent</summary>
	public  void FPhysicsChargeCueEvent(FVector Location,float ElapsedTimeSeconds) {}
	///<summary>OnChargeActivatedEvent</summary>
	public FPhysicsChargeCueEvent OnChargeActivatedEvent;
	///<summary>Charge (not a Cue event, just state)</summary>
	public  void FMockPhysicsNotifyStateChange(bool bNewStateValue) {}
	///<summary>OnChargeStateChange</summary>
	public FMockPhysicsNotifyStateChange OnChargeStateChange;
	///<summary>Currently charging up charge attack</summary>
	public bool bIsCharging;
}
