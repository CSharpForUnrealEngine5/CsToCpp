#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsSettings.h")]
///<summary>Default physics settings.</summary>
public partial class UPhysicsSettings : UPhysicsSettingsCore {
// PhysicsSettings
	public FRigidBodyErrorCorrection PhysicErrorCorrection;
	public byte LockedAxis_DEPRECATED;
	public byte DefaultDegreesOfFreedom;
	public bool bSuppressFaceRemapTable;
	public bool bSupportUVFromHitResults;
	public bool bDisableActiveActors;
	public bool bDisableKinematicStaticPairs;
	public bool bDisableKinematicKinematicPairs;
	public bool bDisableCCD;
	public float AnimPhysicsMinDeltaTime;
	public bool bSimulateAnimPhysicsAfterReset;
	public float MinPhysicsDeltaTime;
	public float MaxPhysicsDeltaTime;
	public bool bSubstepping;
	public bool bSubsteppingAsync;
	public bool bTickPhysicsAsync;
	public float AsyncFixedTimeStepSize;
	public float MaxSubstepDeltaTime;
	public int MaxSubsteps;
	public float SyncSceneSmoothingFactor;
	public float InitialAverageFrameRate;
	public int PhysXTreeRebuildRate;
	public TArray<FPhysicalSurfaceName> PhysicalSurfaces;
	public FBroadphaseSettings DefaultBroadphaseSettings;
	public float MinDeltaVelocityForHitEvents;
	public FChaosPhysicsSettings ChaosSettings;
}
