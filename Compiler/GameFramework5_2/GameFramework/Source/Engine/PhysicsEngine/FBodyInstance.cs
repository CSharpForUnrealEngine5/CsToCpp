#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/BodyInstance.h")]
///<summary>Container for a physics representation of an object</summary>
public partial struct FBodyInstance {
// BodyInstance
	public ECollisionChannel ObjectType;
	public ECollisionEnabled CollisionEnabled;
	public ESleepFamily SleepFamily;
	public EDOFMode DOFMode;
	public bool bUseCCD;
	public bool bIgnoreAnalyticCollisions;
	public bool bNotifyRigidBodyCollision;
	public bool bSmoothEdgeCollisions;
	public bool bLockTranslation;
	public bool bLockRotation;
	public bool bLockXTranslation;
	public bool bLockYTranslation;
	public bool bLockZTranslation;
	public bool bLockXRotation;
	public bool bLockYRotation;
	public bool bLockZRotation;
	public bool bOverrideMaxAngularVelocity;
	public bool bOverrideMaxDepenetrationVelocity;
	public bool bOverrideWalkableSlopeOnInstance;
	public bool bInterpolateWhenSubStepping;
	public bool bInertiaConditioning;
	public FCollisionResponseContainer ResponseToChannels_DEPRECATED;
	public string CollisionProfileName;
	public byte PositionSolverIterationCount;
	public byte VelocitySolverIterationCount;
	public FCollisionResponse CollisionResponses;
	public float MaxDepenetrationVelocity;
	public float MassInKgOverride;
	public float LinearDamping;
	public float AngularDamping;
	public FVector CustomDOFPlaneNormal;
	public FVector COMNudge;
	public float MassScale;
	public FVector InertiaTensorScale;
	public FWalkableSlopeOverride WalkableSlopeOverride;
	public UPhysicalMaterial PhysMaterialOverride;
	public float MaxAngularVelocity;
	public float CustomSleepThresholdMultiplier;
	public float StabilizationThresholdMultiplier;
	public float PhysicsBlendWeight;
}
