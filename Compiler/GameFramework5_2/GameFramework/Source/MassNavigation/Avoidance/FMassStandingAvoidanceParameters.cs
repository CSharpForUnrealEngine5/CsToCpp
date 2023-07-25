#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Avoidance/MassAvoidanceFragments.h")]
public partial struct FMassStandingAvoidanceParameters {
// MassStandingAvoidanceParameters
	public float GhostObstacleDetectionDistance;
	public float GhostToTargetMaxDeviation;
	public float GhostSteeringReactionTime;
	public float GhostStandSlowdownRadius;
	public float GhostMaxSpeed;
	public float GhostMaxAcceleration;
	public float GhostVelocityDampingTime;
	public float GhostSeparationRadiusScale;
	public float GhostSeparationDistance;
	public float GhostSeparationStiffness;
	public float MovingObstacleAvoidanceScale;
	public float MovingObstacleDirectionalScale;
	public float MovingObstaclePersonalSpaceScale;
}
