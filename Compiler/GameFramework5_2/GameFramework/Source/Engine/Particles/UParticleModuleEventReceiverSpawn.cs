#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Event/ParticleModuleEventReceiverSpawn.h")]
public partial class UParticleModuleEventReceiverSpawn : UParticleModuleEventReceiverBase {
// ParticleModuleEventReceiverSpawn
	public FRawDistributionFloat SpawnCount;
	public bool bUseParticleTime;
	public bool bUsePSysLocation;
	public bool bInheritVelocity;
	public FRawDistributionVector InheritVelocityScale;
	public TArray<UPhysicalMaterial> PhysicalMaterials;
	public bool bBanPhysicalMaterials;
}
