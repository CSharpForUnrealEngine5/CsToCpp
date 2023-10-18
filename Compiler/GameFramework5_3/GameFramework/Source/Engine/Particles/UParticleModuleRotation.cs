namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Rotation/ParticleModuleRotation.h")]
public partial class UParticleModuleRotation : UParticleModuleRotationBase {
	public static UClass StaticClass() {return default;}
	///<summary>Initial rotation of the particle (1 = 360 degrees).</summary>
	public FRawDistributionFloat StartRotation;
}
