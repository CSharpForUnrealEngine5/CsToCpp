namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/RotationRate/ParticleModuleRotationRateMultiplyLife.h")]
public partial class UParticleModuleRotationRateMultiplyLife : UParticleModuleRotationRateBase {
	public static UClass StaticClass() {return default;}
	///<summary>The scale factor that should be applied to the rotation rate.</summary>
	public FRawDistributionFloat LifeMultiplier;
}
