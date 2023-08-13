namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Avoidance/MassAvoidanceFragments.h")]
public partial struct FMassMovingAvoidanceParameters {
	public float ObstacleDetectionDistance;
	public float StartOfPathDuration;
	public float EndOfPathDuration;
	public float StartOfPathAvoidanceScale;
	public float EndOfPathAvoidanceScale;
	public float StandingObstacleAvoidanceScale;
	public float StaticObstacleClearanceScale;
	public float SeparationRadiusScale;
	public float ObstacleSeparationStiffness;
	public float ObstacleSeparationDistance;
	public float EnvironmentSeparationStiffness;
	public float EnvironmentSeparationDistance;
	public float PredictiveAvoidanceTime;
	public float PredictiveAvoidanceRadiusScale;
	public float PredictiveAvoidanceDistance;
	public float ObstaclePredictiveAvoidanceStiffness;
	public float EnvironmentPredictiveAvoidanceStiffness;
}
