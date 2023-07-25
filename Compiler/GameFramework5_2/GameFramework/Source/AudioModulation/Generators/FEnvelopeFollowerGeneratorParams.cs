#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Generators/SoundModulationEnvelopeFollower.h")]
public partial struct FEnvelopeFollowerGeneratorParams {
// EnvelopeFollowerGeneratorParams
	public bool bBypass;
	public bool bInvert;
	public UAudioBus AudioBus;
	public float Gain;
	public float AttackTime;
	public float ReleaseTime;
}
