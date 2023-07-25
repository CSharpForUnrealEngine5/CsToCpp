#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsSettingsCore.h")]
///<summary>Default physics settings.</summary>
public partial class UPhysicsSettingsCore : UDeveloperSettings {
// PhysicsSettingsCore
	public float DefaultGravityZ;
	public float DefaultTerminalVelocity;
	public float DefaultFluidFriction;
	public int SimulateScratchMemorySize;
	public int RagdollAggregateThreshold;
	public float TriangleMeshTriangleMinAreaThreshold;
	public bool bEnableEnhancedDeterminism;
	public bool bEnableShapeSharing;
	public bool bEnablePCM;
	public bool bEnableStabilization;
	public bool bWarnMissingLocks;
	public bool bEnable2DPhysics;
	public bool bDefaultHasComplexCollision_DEPRECATED;
	public float BounceThresholdVelocity;
	public byte FrictionCombineMode;
	public byte RestitutionCombineMode;
	public float MaxAngularVelocity;
	public float MaxDepenetrationVelocity;
	public float ContactOffsetMultiplier;
	public float MinContactOffset;
	public float MaxContactOffset;
	public bool bSimulateSkeletalMeshOnDedicatedServer;
	public byte DefaultShapeComplexity;
	public FChaosSolverConfiguration SolverOptions;
}
