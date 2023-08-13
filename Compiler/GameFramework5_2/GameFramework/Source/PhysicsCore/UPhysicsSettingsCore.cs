namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default physics settings.</summary>
[CppInclude("PhysicsSettingsCore.h")]
public partial class UPhysicsSettingsCore : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Default gravity.</summary>
	public float DefaultGravityZ;
	///<summary>Default terminal velocity for Physics Volumes.</summary>
	public float DefaultTerminalVelocity;
	///<summary>Default fluid friction for Physics Volumes.</summary>
	public float DefaultFluidFriction;
	///<summary>Amount of memory to reserve for PhysX simulate(), this is per pxscene and will be rounded up to the next 16K boundary</summary>
	public int SimulateScratchMemorySize;
	///<summary>Threshold for ragdoll bodies above which they will be added to an aggregate before being added to the scene</summary>
	public int RagdollAggregateThreshold;
	///<summary>Triangles from triangle meshes (BSP) with an area less than or equal to this value will be removed from physics collision data. Set to less than 0 to disable.</summary>
	public float TriangleMeshTriangleMinAreaThreshold;
	///<summary>If set to true, the scene will use enhanced determinism at the cost of a bit more resources. See eENABLE_ENHANCED_DETERMINISM to learn about the specifics</summary>
	public bool bEnableEnhancedDeterminism;
	///<summary>Enables shape sharing between sync and async scene for static rigid actors</summary>
	public bool bEnableShapeSharing;
	///<summary>Enables persistent contact manifolds. This will generate fewer contact points, but with more accuracy. Reduces stability of stacking, but can help energy conservation.</summary>
	public bool bEnablePCM;
	///<summary>Enables stabilization of contacts for slow moving bodies. This will help improve the stability of stacking.</summary>
	public bool bEnableStabilization;
	///<summary>Whether to warn when physics locks are used incorrectly. Turning this off is not recommended and should only be used by very advanced users.</summary>
	public bool bWarnMissingLocks;
	///<summary>Can 2D physics be used (Box2D)?</summary>
	public bool bEnable2DPhysics;
	///<summary>If true, static meshes will use per poly collision as complex collision by default. If false the default behavior is the same as UseSimpleAsComplex.</summary>
	public bool bDefaultHasComplexCollision_DEPRECATED;
	///<summary>Minimum relative velocity required for an object to bounce. A typical value for simulation stability is about 0.2 * gravity</summary>
	public float BounceThresholdVelocity;
	///<summary>Friction combine mode, controls how friction is computed for multiple materials.</summary>
	public EFrictionCombineMode FrictionCombineMode;
	///<summary>Restitution combine mode, controls how restitution is computed for multiple materials.</summary>
	public EFrictionCombineMode RestitutionCombineMode;
	///<summary>Max angular velocity that a simulated object can achieve.</summary>
	public float MaxAngularVelocity;
	///<summary>Max velocity which may be used to depenetrate simulated physics objects. 0 means no maximum.</summary>
	public float MaxDepenetrationVelocity;
	///<summary>Contact offset multiplier. When creating a physics shape we look at its bounding volume and multiply its minimum value by this multiplier. A bigger number will generate contact points earlier which results in higher stability at the cost of performance.</summary>
	public float ContactOffsetMultiplier;
	///<summary>Min Contact offset.</summary>
	public float MinContactOffset;
	///<summary>Max Contact offset.</summary>
	public float MaxContactOffset;
	///<summary>If true, simulate physics for this component on a dedicated server.</summary>
	public bool bSimulateSkeletalMeshOnDedicatedServer;
	///<summary>Determines the default physics shape complexity.</summary>
	public ECollisionTraceFlag DefaultShapeComplexity;
	///<summary>Options to apply to Chaos solvers on creation</summary>
	public FChaosSolverConfiguration SolverOptions;
}
