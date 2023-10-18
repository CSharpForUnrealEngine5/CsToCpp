namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Solver settings for use by the Legacy RigidBody AnimNode (RBAN) solver.</summary>
[CppInclude("PhysicsEngine/PhysicsAsset.h")]
public partial struct FSolverIterations {
	public int SolverIterations;
	public int JointIterations;
	public int CollisionIterations;
	public int SolverPushOutIterations;
	public int JointPushOutIterations;
	public int CollisionPushOutIterations;
}
