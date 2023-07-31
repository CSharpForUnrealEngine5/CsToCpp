#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/AvoidanceManager.h")]
public partial class UAvoidanceManager : UObject {
	///<summary>How long an avoidance UID must not be updated before the system will put it back in the pool. Actual delay is up to 150% of this value.</summary>
	public float DefaultTimeToLive;
	///<summary>How long to stay on course (barring collision) after making an avoidance move</summary>
	public float LockTimeAfterAvoid;
	///<summary>How long to stay on course (barring collision) after making an unobstructed move (should be &gt; 0.0, but can be less than a full frame)</summary>
	public float LockTimeAfterClean;
	///<summary>This is how far forward in time (seconds) we extend our velocity cones and thus our prediction</summary>
	public float DeltaTimeToPredict;
	///<summary>Multiply the radius of all STORED avoidance objects by this value to allow a little extra room for avoidance maneuvers.</summary>
	public float ArtificialRadiusExpansion;
	///<summary>Deprecated - use HeightCheckMargin, generally a much smaller value.</summary>
	public float TestHeightDifference_DEPRECATED;
	///<summary>Allowable height margin between obstacles and agents. This is over and above the difference in agent heights.</summary>
	public float HeightCheckMargin;
	///<summary>Get the number of avoidance objects currently in the manager.</summary>
	public  int GetObjectCount() { return default; }
	///<summary>Get appropriate UID for use when reporting to this function or requesting RVO assistance.</summary>
	public  int GetNewAvoidanceUID() { return default; }
	///<summary>Register with the given avoidance manager.</summary>
	public  bool RegisterMovementComponent(UMovementComponent MovementComp,float AvoidanceWeight/*=0.5f*/) { return default; }
	///<summary>Calculate avoidance velocity for component (avoids collisions with the supplied component)</summary>
	public  FVector GetAvoidanceVelocityForComponent(UMovementComponent MovementComp) { return default; }
}
