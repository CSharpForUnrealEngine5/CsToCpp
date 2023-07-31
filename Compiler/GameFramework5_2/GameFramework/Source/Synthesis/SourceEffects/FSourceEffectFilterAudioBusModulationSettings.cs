#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectFilter.h")]
public partial struct FSourceEffectFilterAudioBusModulationSettings {
	public UAudioBus AudioBus;
	public int EnvelopeFollowerAttackTimeMsec;
	public int EnvelopeFollowerReleaseTimeMsec;
	public float EnvelopeGainMultiplier;
	public ESourceEffectFilterParam FilterParam;
	public float MinFrequencyModulation;
	public float MaxFrequencyModulation;
	public float MinResonanceModulation;
	public float MaxResonanceModulation;
}
