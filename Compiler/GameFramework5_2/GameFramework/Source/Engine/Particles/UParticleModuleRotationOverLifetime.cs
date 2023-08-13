namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Rotation/ParticleModuleRotationOverLifetime.h")]
public partial class UParticleModuleRotationOverLifetime : UParticleModuleRotationBase {
	public static UClass StaticClass() {return default;}
	///<summary>The rotation of the particle (1.0 = 360 degrees).</summary>
	public FRawDistributionFloat RotationOverLife;
	///<summary>If true,  the particle rotation is multiplied by the value retrieved from RotationOverLife.</summary>
	public bool Scale;
}
