#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsAsset.h")]
///<summary>Solver settings for use by the Legacy RigidBody AnimNode (RBAN) solver.</summary>
public partial struct FSolverIterations {
// SolverIterations
	public int SolverIterations;
	public int JointIterations;
	public int CollisionIterations;
	public int SolverPushOutIterations;
	public int JointPushOutIterations;
	public int CollisionPushOutIterations;
}
