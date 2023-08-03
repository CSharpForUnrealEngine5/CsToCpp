#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Collision/ParticleModuleCollision.h")]
public partial class UParticleModuleCollision : UParticleModuleCollisionBase {
	public static UClass StaticClass() {return default;}
	///<summary>How much to `slow&#39; the velocity of the particle after a collision.</summary>
	public FRawDistributionVector DampingFactor;
	///<summary>How much to `slow&#39; the rotation of the particle after a collision.</summary>
	public FRawDistributionVector DampingFactorRotation;
	///<summary>The maximum number of collisions a particle can have.</summary>
	public FRawDistributionFloat MaxCollisions;
	///<summary>What to do once a particles MaxCollisions is reached.</summary>
	public EParticleCollisionComplete CollisionCompletionOption;
	///<summary>Which ObjectTypes to collide with</summary>
	public TArray<EObjectTypeQuery> CollisionTypes;
	///<summary>If true, physic will be applied between a particle and the</summary>
	public bool bApplyPhysics;
	///<summary>Any trigger volumes that are hit will be ignored. NOTE: This can be turned off if the TrigerVolume physics object type is not in the CollisionTypes array.</summary>
	public bool bIgnoreTriggerVolumes;
	///<summary>The mass of the particle - for use when bApplyPhysics is true.</summary>
	public FRawDistributionFloat ParticleMass;
	///<summary>The directional scalar value - used to scale the bounds to</summary>
	public float DirScalar;
	///<summary>If true, then collisions with Pawns will still react, but</summary>
	public bool bPawnsDoNotDecrementCount;
	///<summary>If true, then collisions that do not have a vertical hit</summary>
	public bool bOnlyVerticalNormalsDecrementCount;
	///<summary>The fudge factor to use to determine vertical.</summary>
	public float VerticalFudgeFactor;
	///<summary>How long to delay before checking a particle for collisions.</summary>
	public FRawDistributionFloat DelayAmount;
	///<summary>If true, when the World-&gt;bDropDetail flag is set, the module will be ignored.</summary>
	public bool bDropDetail;
	///<summary>If true, Particle collision only if particle system is currently being rendered.</summary>
	public bool bCollideOnlyIfVisible;
	///<summary>If true, then the source actor is ignored in collision checks.</summary>
	public bool bIgnoreSourceActor;
	///<summary>Max distance at which particle collision will occur.</summary>
	public float MaxCollisionDistance;
}
