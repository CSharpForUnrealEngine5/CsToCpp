#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockPhysicsComponent.h")]
///<summary>ActorComponent for running MockPhysicsSimulation</summary>
public partial class UMockPhysicsComponent : UBaseMovementComponent {
// MockPhysicsComponent
	public FMockPhysicsInputCmd PendingInputCmd;
	public void FPhysicsJumpCueEvent(FVector Location,float ElapsedTimeSeconds) {}
	public FPhysicsJumpCueEvent OnJumpActivatedEvent;
	public void FPhysicsChargeCueEvent(FVector Location,float ElapsedTimeSeconds) {}
	public FPhysicsChargeCueEvent OnChargeActivatedEvent;
	public void FMockPhysicsNotifyStateChange(bool bNewStateValue) {}
	public FMockPhysicsNotifyStateChange OnChargeStateChange;
	public bool bIsCharging;
}
