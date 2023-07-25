#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsAsset.h")]
///<summary>Solver iterations settings for use by RigidBody AnimNode (RBAN) in the Anim Graph. Each RBAN node runs its own solver with these settings.</summary>
public partial struct FPhysicsAssetSolverSettings {
// PhysicsAssetSolverSettings
	public int PositionIterations;
	public int VelocityIterations;
	public int ProjectionIterations;
	public float CullDistance;
	public float MaxDepenetrationVelocity;
	public float FixedTimeStep;
	public bool bUseLinearJointSolver;
}
