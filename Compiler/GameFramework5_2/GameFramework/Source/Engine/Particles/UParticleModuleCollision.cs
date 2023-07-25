#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Collision/ParticleModuleCollision.h")]
public partial class UParticleModuleCollision : UParticleModuleCollisionBase {
// ParticleModuleCollision
	public FRawDistributionVector DampingFactor;
	public FRawDistributionVector DampingFactorRotation;
	public FRawDistributionFloat MaxCollisions;
	public byte CollisionCompletionOption;
	public TArray<byte> CollisionTypes;
	public bool bApplyPhysics;
	public bool bIgnoreTriggerVolumes;
	public FRawDistributionFloat ParticleMass;
	public float DirScalar;
	public bool bPawnsDoNotDecrementCount;
	public bool bOnlyVerticalNormalsDecrementCount;
	public float VerticalFudgeFactor;
	public FRawDistributionFloat DelayAmount;
	public bool bDropDetail;
	public bool bCollideOnlyIfVisible;
	public bool bIgnoreSourceActor;
	public float MaxCollisionDistance;
}
