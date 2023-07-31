#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Solver iterations settings for use by RigidBody AnimNode (RBAN) in the Anim Graph. Each RBAN node runs its own solver with these settings.</summary>
[CppInclude("PhysicsEngine/PhysicsAsset.h")]
public partial struct FPhysicsAssetSolverSettings {
	public int PositionIterations;
	public int VelocityIterations;
	public int ProjectionIterations;
	public float CullDistance;
	public float MaxDepenetrationVelocity;
	public float FixedTimeStep;
	public bool bUseLinearJointSolver;
}
