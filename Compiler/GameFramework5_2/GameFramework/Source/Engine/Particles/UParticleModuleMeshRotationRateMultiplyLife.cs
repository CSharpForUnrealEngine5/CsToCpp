#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/RotationRate/ParticleModuleMeshRotationRateMultiplyLife.h")]
public partial class UParticleModuleMeshRotationRateMultiplyLife : UParticleModuleRotationRateBase {
	public static UClass StaticClass() {return default;}
	///<summary>The scale factor that should be applied to the rotation rate.</summary>
	public FRawDistributionVector LifeMultiplier;
}
