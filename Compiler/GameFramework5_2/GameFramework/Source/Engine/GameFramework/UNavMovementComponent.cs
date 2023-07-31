#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>NavMovementComponent defines base functionality for MovementComponents that move any &#39;agent&#39; that may be involved in AI pathfinding.</summary>
[CppInclude("GameFramework/NavMovementComponent.h")]
public partial class UNavMovementComponent : UMovementComponent {
	///<summary>Properties that define how the component can move.</summary>
	public FNavAgentProperties NavAgentProps;
	///<summary>Braking distance override used with acceleration driven path following (bUseAccelerationForPaths)</summary>
	public float FixedPathBrakingDistance;
	///<summary>If set to true NavAgentProps&#39; radius and height will be updated with Owner&#39;s collision capsule size</summary>
	public bool bUpdateNavAgentWithOwnersCollision;
	///<summary>If set, pathfollowing will control character movement via acceleration values. If false, it will set velocities directly.</summary>
	public bool bUseAccelerationForPaths;
	///<summary>If set, FixedPathBrakingDistance will be used for path following deceleration</summary>
	public bool bUseFixedBrakingDistanceForPaths;
	///<summary>Expresses runtime state of character&#39;s movement. Put all temporal changes to movement properties here</summary>
	public FMovementProperties MovementState;
	///<summary>object implementing IPathFollowingAgentInterface. Is private to control access to it.</summary>
	public UObject PathFollowingComp;
	///<summary>Stops applying further movement (usually zeros acceleration).</summary>
	public  void StopActiveMovement() {}
	///<summary>Stops movement immediately (reset velocity) but keeps following current path</summary>
	public  void StopMovementKeepPathing() {}
	///<summary>Returns true if currently crouching</summary>
	public  bool IsCrouching() { return default; }
	///<summary>Returns true if currently falling (not flying, in a non-fluid volume, and not on the ground)</summary>
	public  bool IsFalling() { return default; }
	///<summary>Returns true if currently moving on the ground (e.g. walking or driving)</summary>
	public  bool IsMovingOnGround() { return default; }
	///<summary>Returns true if currently swimming (moving through a fluid volume)</summary>
	public  bool IsSwimming() { return default; }
	///<summary>Returns true if currently flying (moving through a non-fluid volume without resting on the ground)</summary>
	public  bool IsFlying() { return default; }
}
