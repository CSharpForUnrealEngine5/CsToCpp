namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Beam/ParticleModuleBeamModifier.h")]
public partial class UParticleModuleBeamModifier : UParticleModuleBeamBase {
	public static UClass StaticClass() {return default;}
	///<summary>Whether this module modifies the Source or the Target.</summary>
	public BeamModifierType ModifierType;
	///<summary>The options associated with the position.</summary>
	public FBeamModifierOptions PositionOptions;
	///<summary>The value to use when modifying the position.</summary>
	public FRawDistributionVector Position;
	///<summary>The options associated with the Tangent.</summary>
	public FBeamModifierOptions TangentOptions;
	///<summary>The value to use when modifying the Tangent.</summary>
	public FRawDistributionVector Tangent;
	///<summary>If true, don&#39;t transform the tangent modifier into the tangent basis.</summary>
	public bool bAbsoluteTangent;
	///<summary>The options associated with the Strength.</summary>
	public FBeamModifierOptions StrengthOptions;
	///<summary>The value to use when modifying the Strength.</summary>
	public FRawDistributionFloat Strength;
}
