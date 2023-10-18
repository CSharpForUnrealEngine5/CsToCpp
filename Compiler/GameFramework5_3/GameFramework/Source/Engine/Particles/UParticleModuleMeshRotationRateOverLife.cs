namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/RotationRate/ParticleModuleMeshRotationRateOverLife.h")]
public partial class UParticleModuleMeshRotationRateOverLife : UParticleModuleRotationRateBase {
	public static UClass StaticClass() {return default;}
	///<summary>The rotation rate desired.</summary>
	public FRawDistributionVector RotRate;
	///<summary>If true, scale the current rotation rate by the value retrieved.</summary>
	public bool bScaleRotRate;
}
