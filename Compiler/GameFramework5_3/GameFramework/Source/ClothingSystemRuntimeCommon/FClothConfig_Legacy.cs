namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deprecated, legacy definition kept for backward compatibility only.</summary>
[CppInclude("ClothConfig_Legacy.h")]
public partial struct FClothConfig_Legacy {
	public EClothingWindMethod_Legacy WindMethod;
	public FClothConstraintSetup_Legacy VerticalConstraintConfig;
	public FClothConstraintSetup_Legacy HorizontalConstraintConfig;
	public FClothConstraintSetup_Legacy BendConstraintConfig;
	public FClothConstraintSetup_Legacy ShearConstraintConfig;
	public float SelfCollisionRadius;
	public float SelfCollisionStiffness;
	public float SelfCollisionCullScale;
	public FVector Damping;
	public float Friction;
	public float WindDragCoefficient;
	public float WindLiftCoefficient;
	public FVector LinearDrag;
	public FVector AngularDrag;
	public FVector LinearInertiaScale;
	public FVector AngularInertiaScale;
	public FVector CentrifugalInertiaScale;
	public float SolverFrequency;
	public float StiffnessFrequency;
	public float GravityScale;
	public FVector GravityOverride;
	public bool bUseGravityOverride;
	public float TetherStiffness;
	public float TetherLimit;
	public float CollisionThickness;
	public float AnimDriveSpringStiffness;
	public float AnimDriveDamperStiffness;
}
