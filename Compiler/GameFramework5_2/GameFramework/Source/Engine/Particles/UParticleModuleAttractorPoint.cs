#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Attractor/ParticleModuleAttractorPoint.h")]
public partial class UParticleModuleAttractorPoint : UParticleModuleAttractorBase {
// ParticleModuleAttractorPoint
	public FRawDistributionVector Position;
	public FRawDistributionFloat Range;
	public FRawDistributionFloat Strength;
	public bool StrengthByDistance;
	public bool bAffectBaseVelocity;
	public bool bOverrideVelocity;
	public bool bUseWorldSpacePosition;
	public bool Positive_X;
	public bool Positive_Y;
	public bool Positive_Z;
	public bool Negative_X;
	public bool Negative_Y;
	public bool Negative_Z;
}
