#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_AnimDynamics.h")]
public partial struct FAnimNode_AnimDynamics {
	public float LinearDampingOverride;
	public float AngularDampingOverride;
	public FBoneReference RelativeSpaceBone;
	public FBoneReference BoundBone;
	public FBoneReference ChainEnd;
	public TArray<FAnimPhysBodyDefinition> PhysicsBodyDefinitions;
	public float GravityScale;
	public FVector GravityOverride;
	public float LinearSpringConstant;
	public float AngularSpringConstant;
	public float WindScale;
	public FVector ComponentLinearAccScale;
	public FVector ComponentLinearVelScale;
	public FVector ComponentAppliedLinearAccClamp;
	public float AngularBiasOverride;
	public int NumSolverIterationsPreUpdate;
	public int NumSolverIterationsPostUpdate;
	public TArray<FAnimPhysSphericalLimit> SphericalLimits;
	public FVector ExternalForce;
	public TArray<FAnimPhysPlanarLimit> PlanarLimits;
	public AnimPhysSimSpaceType SimulationSpace;
	public bool bUseSphericalLimits;
	public bool bUsePlanarLimit;
	public bool bDoUpdate;
	public bool bDoEval;
	public bool bOverrideLinearDamping;
	public bool bOverrideAngularBias;
	public bool bOverrideAngularDamping;
	public bool bEnableWind;
	public bool bUseGravityOverride;
	public bool bGravityOverrideInSimSpace;
	public bool bLinearSpring;
	public bool bAngularSpring;
	public bool bChain;
	public FRotationRetargetingInfo RetargetingSettings;
	public FVector BoxExtents_DEPRECATED;
	public FVector LocalJointOffset_DEPRECATED;
	public FAnimPhysConstraintSetup ConstraintSetup_DEPRECATED;
	public AnimPhysCollisionType CollisionType_DEPRECATED;
	public float SphereCollisionRadius_DEPRECATED;
}
