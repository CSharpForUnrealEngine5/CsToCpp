#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Attractor/ParticleModuleAttractorParticle.h")]
public partial class UParticleModuleAttractorParticle : UParticleModuleAttractorBase {
// ParticleModuleAttractorParticle
	public string EmitterName;
	public FRawDistributionFloat Range;
	public bool bStrengthByDistance;
	public FRawDistributionFloat Strength;
	public bool bAffectBaseVelocity;
	public byte SelectionMethod;
	public bool bRenewSource;
	public bool bInheritSourceVel;
	public int LastSelIndex;
}
