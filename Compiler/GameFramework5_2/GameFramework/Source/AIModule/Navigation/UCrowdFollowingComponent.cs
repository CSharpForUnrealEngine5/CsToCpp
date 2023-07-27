#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/CrowdFollowingComponent.h")]
public partial class UCrowdFollowingComponent : UPathFollowingComponent {
// CrowdFollowingComponent
	public  void SuspendCrowdSteering(bool bSuspend) {}
	public FVector CrowdAgentMoveDirection;
	public UCharacterMovementComponent CharacterMovement;
	public FNavAvoidanceMask AvoidanceGroup_DEPRECATED;
	public FNavAvoidanceMask GroupsToAvoid_DEPRECATED;
	public FNavAvoidanceMask GroupsToIgnore_DEPRECATED;
}
