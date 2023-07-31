#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Event/ParticleModuleEventReceiverSpawn.h")]
public partial class UParticleModuleEventReceiverSpawn : UParticleModuleEventReceiverBase {
	///<summary>The number of particles to spawn.</summary>
	public FRawDistributionFloat SpawnCount;
	///<summary>For Death-based event receiving, if this is true, it indicates that the</summary>
	public bool bUseParticleTime;
	///<summary>If true, use the location of the particle system component for spawning.</summary>
	public bool bUsePSysLocation;
	///<summary>If true, use the velocity of the dying particle as the start velocity of</summary>
	public bool bInheritVelocity;
	///<summary>If bInheritVelocity is true, scale the velocity with this.</summary>
	public FRawDistributionVector InheritVelocityScale;
	///<summary>Array of physical materials that can be used to allow or ban a specific set of materials when receiving collision events.</summary>
	public TArray<UPhysicalMaterial> PhysicalMaterials;
	///<summary>When true, the PhysicalMaterials list is used to ban specified materials for collision events but allow all others.</summary>
	public bool bBanPhysicalMaterials;
}
