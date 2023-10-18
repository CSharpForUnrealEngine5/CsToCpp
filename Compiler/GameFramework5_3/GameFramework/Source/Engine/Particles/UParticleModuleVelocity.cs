namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Velocity/ParticleModuleVelocity.h")]
public partial class UParticleModuleVelocity : UParticleModuleVelocityBase {
	public static UClass StaticClass() {return default;}
	///<summary>The velocity to apply to a particle when it is spawned.</summary>
	public FRawDistributionVector StartVelocity;
	///<summary>The velocity to apply to a particle along its radial direction.</summary>
	public FRawDistributionFloat StartVelocityRadial;
}
