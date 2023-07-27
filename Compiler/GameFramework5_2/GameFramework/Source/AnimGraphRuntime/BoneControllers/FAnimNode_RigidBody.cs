#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_RigidBody.h")]
///<summary>Controller that simulates physics based on the physics asset of the skeletal mesh component</summary>
public partial struct FAnimNode_RigidBody {
// AnimNode_RigidBody
	public UPhysicsAsset OverridePhysicsAsset;
	public FVector OverrideWorldGravity;
	public FVector ExternalForce;
	public FVector ComponentLinearAccScale;
	public FVector ComponentLinearVelScale;
	public FVector ComponentAppliedLinearAccClamp;
	public FSimSpaceSettings SimSpaceSettings;
	public float CachedBoundsScale;
	public FBoneReference BaseBoneRef;
	public ECollisionChannel OverlapChannel;
	public ESimulationSpace SimulationSpace;
	public bool bForceDisableCollisionBetweenConstraintBodies;
	public bool bUseExternalClothCollision;
	public bool bEnableWorldGeometry;
	public bool bOverrideWorldGravity;
	public bool bTransferBoneVelocities;
	public bool bFreezeIncomingPoseOnStart;
	public bool bClampLinearTranslationLimitToRefPose;
	public float WorldSpaceMinimumScale;
	public float EvaluationResetTime;
	public bool bComponentSpaceSimulation_DEPRECATED;
	public ESimulationTiming SimulationTiming;
}
