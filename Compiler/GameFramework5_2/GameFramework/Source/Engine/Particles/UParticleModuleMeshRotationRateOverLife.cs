#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/RotationRate/ParticleModuleMeshRotationRateOverLife.h")]
public partial class UParticleModuleMeshRotationRateOverLife : UParticleModuleRotationRateBase {
	///<summary>The rotation rate desired.</summary>
	public FRawDistributionVector RotRate;
	///<summary>If true, scale the current rotation rate by the value retrieved.</summary>
	public bool bScaleRotRate;
}
