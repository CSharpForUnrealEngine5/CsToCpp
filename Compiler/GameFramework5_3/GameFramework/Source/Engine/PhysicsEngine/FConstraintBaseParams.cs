namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintTypes.h")]
public partial struct FConstraintBaseParams {
	public float Stiffness;
	public float Damping;
	public float Restitution;
	public float ContactDistance;
	public bool bSoftConstraint;
}
