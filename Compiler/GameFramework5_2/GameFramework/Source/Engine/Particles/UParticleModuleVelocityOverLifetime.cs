#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Velocity/ParticleModuleVelocityOverLifetime.h")]
public partial class UParticleModuleVelocityOverLifetime : UParticleModuleVelocityBase {
	public static UClass StaticClass() {return default;}
	///<summary>The scaling  value applied to the velocity.</summary>
	public FRawDistributionVector VelOverLife;
	///<summary>If true, the velocity will be SET to the value from the above dist.</summary>
	public bool Absolute;
}
