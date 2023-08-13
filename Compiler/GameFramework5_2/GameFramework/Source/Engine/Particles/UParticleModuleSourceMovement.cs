namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleSourceMovement.h")]
public partial class UParticleModuleSourceMovement : UParticleModuleLocationBase {
	public static UClass StaticClass() {return default;}
	///<summary>The scale factor to apply to the source movement before adding to the particle location.</summary>
	public FRawDistributionVector SourceMovementScale;
}
