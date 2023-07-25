#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Spawn/ParticleModuleSpawnPerUnit.h")]
public partial class UParticleModuleSpawnPerUnit : UParticleModuleSpawnBase {
// ParticleModuleSpawnPerUnit
	public float UnitScalar;
	public float MovementTolerance;
	public FRawDistributionFloat SpawnPerUnit;
	public float MaxFrameDistance;
	public bool bIgnoreSpawnRateWhenMoving;
	public bool bIgnoreMovementAlongX;
	public bool bIgnoreMovementAlongY;
	public bool bIgnoreMovementAlongZ;
}
