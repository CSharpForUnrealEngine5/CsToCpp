#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Acceleration/ParticleModuleAccelerationOverLifetime.h")]
public partial class UParticleModuleAccelerationOverLifetime : UParticleModuleAccelerationBase {
	public static UClass StaticClass() {return default;}
	///<summary>The acceleration of the particle over its lifetime.</summary>
	public FRawDistributionVector AccelOverLife;
}
