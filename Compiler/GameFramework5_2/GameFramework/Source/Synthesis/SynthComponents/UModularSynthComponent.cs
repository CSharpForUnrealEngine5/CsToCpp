#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/EpicSynth1Component.h")]
///<summary>UModularSynthComponent</summary>
public partial class UModularSynthComponent : USynthComponent {
// ModularSynthComponent
	public int VoiceCount;
	public void NoteOn(float Note,int Velocity,float Duration/*=-1.0f*/) {}
	public void NoteOff(float Note,bool bAllNotesOff/*=false*/,bool bKillAllNotes/*=false*/) {}
	public void SetEnablePolyphony(bool bEnablePolyphony) {}
	public void SetOscGain(int OscIndex,float OscGain) {}
	public void SetOscGainMod(int OscIndex,float OscGainMod) {}
	public void SetOscFrequencyMod(int OscIndex,float OscFreqMod) {}
	public void SetOscType(int OscIndex,ESynth1OscType OscType) {}
	public void SetOscOctave(int OscIndex,float Octave) {}
	public void SetOscSemitones(int OscIndex,float Semitones) {}
	public void SetOscCents(int OscIndex,float Cents) {}
	public void SetPitchBend(float PitchBend) {}
	public void SetPortamento(float Portamento) {}
	public void SetOscPulsewidth(int OscIndex,float Pulsewidth) {}
	public void SetEnableUnison(bool EnableUnison) {}
	public void SetOscSync(bool bIsSynced) {}
	public void SetPan(float Pan) {}
	public void SetSpread(float Spread) {}
	public void SetLFOFrequency(int LFOIndex,float FrequencyHz) {}
	public void SetLFOFrequencyMod(int LFOIndex,float FrequencyModHz) {}
	public void SetLFOGain(int LFOIndex,float Gain) {}
	public void SetLFOGainMod(int LFOIndex,float GainMod) {}
	public void SetLFOType(int LFOIndex,ESynthLFOType LFOType) {}
	public void SetLFOMode(int LFOIndex,ESynthLFOMode LFOMode) {}
	public void SetLFOPatch(int LFOIndex,ESynthLFOPatchType LFOPatchType) {}
	public void SetGainDb(float GainDb) {}
	public void SetAttackTime(float AttackTimeMsec) {}
	public void SetDecayTime(float DecayTimeMsec) {}
	public void SetSustainGain(float SustainGain) {}
	public void SetReleaseTime(float ReleaseTimeMsec) {}
	public void SetModEnvPatch(ESynthModEnvPatch InPatchType) {}
	public void SetModEnvBiasPatch(ESynthModEnvBiasPatch InPatchType) {}
	public void SetModEnvInvert(bool bInvert) {}
	public void SetModEnvBiasInvert(bool bInvert) {}
	public void SetModEnvDepth(float Depth) {}
	public void SetModEnvAttackTime(float AttackTimeMsec) {}
	public void SetModEnvDecayTime(float DecayTimeMsec) {}
	public void SetModEnvSustainGain(float SustainGain) {}
	public void SetModEnvReleaseTime(float Release) {}
	public void SetEnableLegato(bool LegatoEnabled) {}
	public void SetEnableRetrigger(bool RetriggerEnabled) {}
	public void SetFilterFrequency(float FilterFrequencyHz) {}
	public void SetFilterFrequencyMod(float FilterFrequencyHz) {}
	public void SetFilterQ(float FilterQ) {}
	public void SetFilterQMod(float FilterQ) {}
	public void SetFilterType(ESynthFilterType FilterType) {}
	public void SetFilterAlgorithm(ESynthFilterAlgorithm FilterAlgorithm) {}
	public void SetStereoDelayIsEnabled(bool StereoDelayEnabled) {}
	public void SetStereoDelayMode(ESynthStereoDelayMode StereoDelayMode) {}
	public void SetStereoDelayTime(float DelayTimeMsec) {}
	public void SetStereoDelayFeedback(float DelayFeedback) {}
	public void SetStereoDelayWetlevel(float DelayWetlevel) {}
	public void SetStereoDelayRatio(float DelayRatio) {}
	public void SetChorusEnabled(bool EnableChorus) {}
	public void SetChorusDepth(float Depth) {}
	public void SetChorusFeedback(float Feedback) {}
	public void SetChorusFrequency(float Frequency) {}
	public void SetSynthPreset(FModularSynthPreset SynthPreset) {}
	public FPatchId CreatePatch(ESynth1PatchSource PatchSource,TArray<FSynth1PatchCable> PatchCables,bool bEnableByDefault) { return default; }
	public bool SetEnablePatch(FPatchId PatchId,bool bIsEnabled) { return default; }
}
