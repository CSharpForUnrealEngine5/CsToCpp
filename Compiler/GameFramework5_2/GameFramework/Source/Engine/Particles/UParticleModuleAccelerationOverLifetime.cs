namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Acceleration/ParticleModuleAccelerationOverLifetime.h")]
public partial class UParticleModuleAccelerationOverLifetime : UParticleModuleAccelerationBase {
	public static UClass StaticClass() {return default;}
	///<summary>The acceleration of the particle over its lifetime.</summary>
	public FRawDistributionVector AccelOverLife;
}
