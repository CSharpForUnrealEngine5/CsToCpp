#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosSolverConfiguration.h")]
public partial struct FChaosSolverConfiguration {
	public int PositionIterations;
	public int VelocityIterations;
	public int ProjectionIterations;
	public float CollisionMarginFraction;
	public float CollisionMarginMax;
	public float CollisionCullDistance;
	public float CollisionMaxPushOutVelocity;
	public float ClusterConnectionFactor;
	public EClusterUnionMethod ClusterUnionConnectionType;
	public bool bGenerateCollisionData;
	public FSolverCollisionFilterSettings CollisionFilterSettings;
	public bool bGenerateBreakData;
	public FSolverBreakingFilterSettings BreakingFilterSettings;
	public bool bGenerateTrailingData;
	public FSolverTrailingFilterSettings TrailingFilterSettings;
	public int Iterations_DEPRECATED;
	public int PushOutIterations_DEPRECATED;
	public bool bGenerateContactGraph_DEPRECATED;
}
