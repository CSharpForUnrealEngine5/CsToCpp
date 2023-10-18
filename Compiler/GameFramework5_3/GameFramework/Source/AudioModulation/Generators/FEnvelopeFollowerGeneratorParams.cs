namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Generators/SoundModulationEnvelopeFollower.h")]
public partial struct FEnvelopeFollowerGeneratorParams {
	public bool bBypass;
	public bool bInvert;
	public UAudioBus AudioBus;
	public float Gain;
	public float AttackTime;
	public float ReleaseTime;
}
