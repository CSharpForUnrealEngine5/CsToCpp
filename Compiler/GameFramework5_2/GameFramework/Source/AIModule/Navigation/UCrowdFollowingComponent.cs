#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/CrowdFollowingComponent.h")]
public partial class UCrowdFollowingComponent : UPathFollowingComponent {
	public static UClass StaticClass() {return default;}
	///<summary>main switch for crowd steering &amp; avoidance</summary>
	public  void SuspendCrowdSteering(bool bSuspend) {}
	///<summary>CrowdAgentMoveDirection</summary>
	public FVector CrowdAgentMoveDirection;
	///<summary>CharacterMovement</summary>
	public UCharacterMovementComponent CharacterMovement;
	///<summary>DEPRECATED: Group mask for this agent - use IRVOAvoidanceInterface instead</summary>
	public FNavAvoidanceMask AvoidanceGroup_DEPRECATED;
	///<summary>DEPRECATED: Will avoid other agents if they are in one of specified groups - use IRVOAvoidanceInterface instead</summary>
	public FNavAvoidanceMask GroupsToAvoid_DEPRECATED;
	///<summary>DEPRECATED: Will NOT avoid other agents if they are in one of specified groups, higher priority than GroupsToAvoid - use IRVOAvoidanceInterface instead</summary>
	public FNavAvoidanceMask GroupsToIgnore_DEPRECATED;
}
