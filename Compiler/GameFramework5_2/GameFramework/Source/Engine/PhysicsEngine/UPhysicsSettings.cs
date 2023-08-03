#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default physics settings.</summary>
[CppInclude("PhysicsEngine/PhysicsSettings.h")]
public partial class UPhysicsSettings : UPhysicsSettingsCore {
	public static UClass StaticClass() {return default;}
	///<summary>Error correction data for replicating simulated physics (rigid bodies)</summary>
	public FRigidBodyErrorCorrection PhysicErrorCorrection;
	///<summary>LockedAxis_DEPRECATED</summary>
	public ESettingsLockedAxis LockedAxis_DEPRECATED;
	///<summary>Useful for constraining all objects in the world, for example if you are making a 2D game using 3D environments.</summary>
	public ESettingsDOF DefaultDegreesOfFreedom;
	///<summary>If true, the internal physx face to UE face mapping will not be generated. This is a memory optimization available if you do not rely on face indices returned by scene queries.</summary>
	public bool bSuppressFaceRemapTable;
	///<summary>If true, store extra information to allow FindCollisionUV to derive UV info from a line trace hit result, using the FindCollisionUV utility</summary>
	public bool bSupportUVFromHitResults;
	///<summary>If true, physx will not update unreal with any bodies that have moved during the simulation. This should only be used if you have no physx simulation or you are manually updating the unreal data via polling physx.</summary>
	public bool bDisableActiveActors;
	///<summary>Whether to disable generating KS pairs, enabling this makes switching between dynamic and static slower for actors - but speeds up contact generation by early rejecting these pairs</summary>
	public bool bDisableKinematicStaticPairs;
	///<summary>Whether to disable generating KK pairs, enabling this speeds up contact generation, however it is required when using APEX destruction.</summary>
	public bool bDisableKinematicKinematicPairs;
	///<summary>If true CCD will be ignored. This is an optimization when CCD is never used which removes the need for physx to check it internally.</summary>
	public bool bDisableCCD;
	///<summary>Min Delta Time below which anim dynamics and rigidbody nodes will not simulate.</summary>
	public float AnimPhysicsMinDeltaTime;
	///<summary>Whether to simulate anim physics nodes in the tick where they&#39;re reset.</summary>
	public bool bSimulateAnimPhysicsAfterReset;
	///<summary>Min Physics Delta Time; the simulation will not step if the delta time is below this value</summary>
	public float MinPhysicsDeltaTime;
	///<summary>Max Physics Delta Time to be clamped.</summary>
	public float MaxPhysicsDeltaTime;
	///<summary>Whether to substep the physics simulation. This feature is still experimental. Certain functionality might not work correctly</summary>
	public bool bSubstepping;
	///<summary>Whether to substep the async physics simulation. This feature is still experimental. Certain functionality might not work correctly</summary>
	public bool bSubsteppingAsync;
	///<summary>Whether to tick physics simulation on an async thread. This feature is still experimental. Certain functionality might not work correctly</summary>
	public bool bTickPhysicsAsync;
	///<summary>If using async, the time step size to tick at. This feature is still experimental. Certain functionality might not work correctly</summary>
	public float AsyncFixedTimeStepSize;
	///<summary>Max delta time (in seconds) for an individual simulation substep.</summary>
	public float MaxSubstepDeltaTime;
	///<summary>Max number of substeps for physics simulation.</summary>
	public int MaxSubsteps;
	///<summary>Physics delta time smoothing factor for sync scene.</summary>
	public float SyncSceneSmoothingFactor;
	///<summary>Physics delta time initial average.</summary>
	public float InitialAverageFrameRate;
	///<summary>The number of frames it takes to rebuild the PhysX scene query AABB tree. The bigger the number, the smaller fetchResults takes per frame, but the more the tree deteriorates until a new tree is built</summary>
	public int PhysXTreeRebuildRate;
	///<summary>PhysicalMaterial Surface Types</summary>
	public TArray<FPhysicalSurfaceName> PhysicalSurfaces;
	///<summary>If we want to Enable MPB or not globally. This is then overridden by project settings if not enabled. *</summary>
	public FBroadphaseSettings DefaultBroadphaseSettings;
	///<summary>Minimum velocity delta required on a collinding object for Chaos to send a hit event</summary>
	public float MinDeltaVelocityForHitEvents;
	///<summary>Chaos physics engine settings</summary>
	public FChaosPhysicsSettings ChaosSettings;
}
