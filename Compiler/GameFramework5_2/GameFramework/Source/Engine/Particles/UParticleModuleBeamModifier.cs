#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Beam/ParticleModuleBeamModifier.h")]
public partial class UParticleModuleBeamModifier : UParticleModuleBeamBase {
// ParticleModuleBeamModifier
	public byte ModifierType;
	public FBeamModifierOptions PositionOptions;
	public FRawDistributionVector Position;
	public FBeamModifierOptions TangentOptions;
	public FRawDistributionVector Tangent;
	public bool bAbsoluteTangent;
	public FBeamModifierOptions StrengthOptions;
	public FRawDistributionFloat Strength;
}
