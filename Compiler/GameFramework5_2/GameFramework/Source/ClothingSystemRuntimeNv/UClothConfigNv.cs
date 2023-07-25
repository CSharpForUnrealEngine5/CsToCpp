#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothConfigNv.h")]
public partial class UClothConfigNv : UClothConfigCommon {
// ClothConfigNv
	public EClothingWindMethodNv ClothingWindMethod;
	public FClothConstraintSetupNv VerticalConstraint;
	public FClothConstraintSetupNv HorizontalConstraint;
	public FClothConstraintSetupNv BendConstraint;
	public FClothConstraintSetupNv ShearConstraint;
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
	public EClothingWindMethod_Legacy WindMethod_DEPRECATED;
	public FClothConstraintSetup_Legacy VerticalConstraintConfig_DEPRECATED;
	public FClothConstraintSetup_Legacy HorizontalConstraintConfig_DEPRECATED;
	public FClothConstraintSetup_Legacy BendConstraintConfig_DEPRECATED;
	public FClothConstraintSetup_Legacy ShearConstraintConfig_DEPRECATED;
}
