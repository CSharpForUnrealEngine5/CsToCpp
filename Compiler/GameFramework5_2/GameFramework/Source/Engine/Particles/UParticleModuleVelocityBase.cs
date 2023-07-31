#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Velocity/ParticleModuleVelocityBase.h")]
public partial class UParticleModuleVelocityBase : UParticleModule {
	///<summary>If true, then treat the velocity as world-space defined.</summary>
	public bool bInWorldSpace;
	///<summary>If true, then apply the particle system components scale to the velocity value.</summary>
	public bool bApplyOwnerScale;
}
