namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Math/Simulation/CRSimSoftCollision.h")]
public partial struct FCRSimSoftCollision {
	public FTransform Transform;
	public ECRSimSoftCollisionType ShapeType;
	public float MinimumDistance;
	public float MaximumDistance;
	public ERigVMAnimEasingType FalloffType;
	public float Coefficient;
	public bool bInverted;
}
