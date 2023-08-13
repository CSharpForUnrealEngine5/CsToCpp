namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/EpicSynth1Component.h")]
public partial struct FModularSynthPreset {
	public bool bEnablePolyphony;
	public ESynth1OscType Osc1Type;
	public float Osc1Gain;
	public float Osc1Octave;
	public float Osc1Semitones;
	public float Osc1Cents;
	public float Osc1PulseWidth;
	public ESynth1OscType Osc2Type;
	public float Osc2Gain;
	public float Osc2Octave;
	public float Osc2Semitones;
	public float Osc2Cents;
	public float Osc2PulseWidth;
	public float Portamento;
	public bool bEnableUnison;
	public bool bEnableOscillatorSync;
	public float Spread;
	public float Pan;
	public float LFO1Frequency;
	public float LFO1Gain;
	public ESynthLFOType LFO1Type;
	public ESynthLFOMode LFO1Mode;
	public ESynthLFOPatchType LFO1PatchType;
	public float LFO2Frequency;
	public float LFO2Gain;
	public ESynthLFOType LFO2Type;
	public ESynthLFOMode LFO2Mode;
	public ESynthLFOPatchType LFO2PatchType;
	public float GainDb;
	public float AttackTime;
	public float DecayTime;
	public float SustainGain;
	public float ReleaseTime;
	public ESynthModEnvPatch ModEnvPatchType;
	public ESynthModEnvBiasPatch ModEnvBiasPatchType;
	public bool bInvertModulationEnvelope;
	public bool bInvertModulationEnvelopeBias;
	public float ModulationEnvelopeDepth;
	public float ModulationEnvelopeAttackTime;
	public float ModulationEnvelopeDecayTime;
	public float ModulationEnvelopeSustainGain;
	public float ModulationEnvelopeReleaseTime;
	public bool bLegato;
	public bool bRetrigger;
	public float FilterFrequency;
	public float FilterQ;
	public ESynthFilterType FilterType;
	public ESynthFilterAlgorithm FilterAlgorithm;
	public bool bStereoDelayEnabled;
	public ESynthStereoDelayMode StereoDelayMode;
	public float StereoDelayTime;
	public float StereoDelayFeedback;
	public float StereoDelayWetlevel;
	public float StereoDelayRatio;
	public bool bChorusEnabled;
	public float ChorusDepth;
	public float ChorusFeedback;
	public float ChorusFrequency;
	public TArray<FEpicSynth1Patch> Patches;
}
