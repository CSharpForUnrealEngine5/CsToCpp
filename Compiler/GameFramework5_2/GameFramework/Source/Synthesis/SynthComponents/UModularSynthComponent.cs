#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UModularSynthComponent</summary>
[CppInclude("SynthComponents/EpicSynth1Component.h")]
public partial class UModularSynthComponent : USynthComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The voice count to use for the synthesizer. Cannot be changed</summary>
	public int VoiceCount;
	///<summary>Play a new note. Optionally pass in a duration to automatically turn off the note.</summary>
	public  void NoteOn(float Note,int Velocity,float Duration/*=-1.0f*/) {}
	///<summary>Stop the note (will only do anything if a voice is playing with that note)</summary>
	public  void NoteOff(float Note,bool bAllNotesOff/*=false*/,bool bKillAllNotes/*=false*/) {}
	///<summary>Sets whether or not to use polyphony for the synthesizer.</summary>
	public  void SetEnablePolyphony(bool bEnablePolyphony) {}
	///<summary>Set the oscillator gain.</summary>
	public  void SetOscGain(int OscIndex,float OscGain) {}
	///<summary>Set the oscillator gain modulation.</summary>
	public  void SetOscGainMod(int OscIndex,float OscGainMod) {}
	///<summary>Set the oscillator frequency modulation</summary>
	public  void SetOscFrequencyMod(int OscIndex,float OscFreqMod) {}
	///<summary>Set the oscillator type.</summary>
	public  void SetOscType(int OscIndex,ESynth1OscType OscType) {}
	///<summary>Sets the oscillator octaves</summary>
	public  void SetOscOctave(int OscIndex,float Octave) {}
	///<summary>Sets the oscillator semitones.</summary>
	public  void SetOscSemitones(int OscIndex,float Semitones) {}
	///<summary>Sets the oscillator cents.</summary>
	public  void SetOscCents(int OscIndex,float Cents) {}
	///<summary>Sets the synth pitch bend amount.</summary>
	public  void SetPitchBend(float PitchBend) {}
	///<summary>Sets the synth portamento [0.0, 1.0]</summary>
	public  void SetPortamento(float Portamento) {}
	///<summary>Sets the square wave pulsewidth [0.0, 1.0]</summary>
	public  void SetOscPulsewidth(int OscIndex,float Pulsewidth) {}
	///<summary>Sets whether or not the synth is in unison mode (i.e. no spread)</summary>
	public  void SetEnableUnison(bool EnableUnison) {}
	///<summary>Set whether or not to follow the phase of osc2 to osc1</summary>
	public  void SetOscSync(bool bIsSynced) {}
	///<summary>Sets the pan of the synth [-1.0, 1.0].</summary>
	public  void SetPan(float Pan) {}
	///<summary>Sets the amount of spread of the oscillators. [0.0, 1.0]</summary>
	public  void SetSpread(float Spread) {}
	///<summary>Sets the LFO frequency in hz</summary>
	public  void SetLFOFrequency(int LFOIndex,float FrequencyHz) {}
	///<summary>Sets the LFO frequency modulation in hz</summary>
	public  void SetLFOFrequencyMod(int LFOIndex,float FrequencyModHz) {}
	///<summary>Sets the LFO gain factor</summary>
	public  void SetLFOGain(int LFOIndex,float Gain) {}
	///<summary>Sets the LFO gain mod factor (external modulation)</summary>
	public  void SetLFOGainMod(int LFOIndex,float GainMod) {}
	///<summary>Sets the LFO type</summary>
	public  void SetLFOType(int LFOIndex,ESynthLFOType LFOType) {}
	///<summary>Sets the LFO type</summary>
	public  void SetLFOMode(int LFOIndex,ESynthLFOMode LFOMode) {}
	///<summary>Sets the LFO patch type. LFO patch determines what parameter is modulated by the LFO.</summary>
	public  void SetLFOPatch(int LFOIndex,ESynthLFOPatchType LFOPatchType) {}
	///<summary>Sets the synth gain in decibels.</summary>
	public  void SetGainDb(float GainDb) {}
	///<summary>Sets the envelope attack time in msec.</summary>
	public  void SetAttackTime(float AttackTimeMsec) {}
	///<summary>Sets the envelope decay time in msec.</summary>
	public  void SetDecayTime(float DecayTimeMsec) {}
	///<summary>Sets the envelope sustain gain value.</summary>
	public  void SetSustainGain(float SustainGain) {}
	///<summary>Sets the envelope release time in msec.</summary>
	public  void SetReleaseTime(float ReleaseTimeMsec) {}
	///<summary>Sets whether or not to modulate a param based on the envelope. Uses bias envelope output (offset from sustain gain).</summary>
	public  void SetModEnvPatch(ESynthModEnvPatch InPatchType) {}
	///<summary>Sets whether or not to modulate a param based on the envelope. Uses bias envelope output (offset from sustain gain).</summary>
	public  void SetModEnvBiasPatch(ESynthModEnvBiasPatch InPatchType) {}
	///<summary>Sets whether or not to invert the envelope modulator.</summary>
	public  void SetModEnvInvert(bool bInvert) {}
	///<summary>Sets whether or not to invert the bias output of the envelope modulator.</summary>
	public  void SetModEnvBiasInvert(bool bInvert) {}
	///<summary>Sets the envelope modulator depth (amount to apply the output modulation)</summary>
	public  void SetModEnvDepth(float Depth) {}
	///<summary>Sets the envelope modulator attack time in msec</summary>
	public  void SetModEnvAttackTime(float AttackTimeMsec) {}
	///<summary>Sets the envelope modulator attack time in msec</summary>
	public  void SetModEnvDecayTime(float DecayTimeMsec) {}
	///<summary>Sets the envelope modulator sustain gain</summary>
	public  void SetModEnvSustainGain(float SustainGain) {}
	///<summary>Sets the envelope modulator release</summary>
	public  void SetModEnvReleaseTime(float Release) {}
	///<summary>Sets whether or not to use legato for the synthesizer.</summary>
	public  void SetEnableLegato(bool LegatoEnabled) {}
	///<summary>Sets whether or not to retrigger envelope per note on.</summary>
	public  void SetEnableRetrigger(bool RetriggerEnabled) {}
	///<summary>Sets the filter cutoff frequency in hz.</summary>
	public  void SetFilterFrequency(float FilterFrequencyHz) {}
	///<summary>Sets the filter cutoff frequency in hz.</summary>
	public  void SetFilterFrequencyMod(float FilterFrequencyHz) {}
	///<summary>Sets the filter Q (resonance)</summary>
	public  void SetFilterQ(float FilterQ) {}
	///<summary>Sets a modulated filter Q (resonance)</summary>
	public  void SetFilterQMod(float FilterQ) {}
	///<summary>Sets the filter type.</summary>
	public  void SetFilterType(ESynthFilterType FilterType) {}
	///<summary>Sets the filter algorithm.</summary>
	public  void SetFilterAlgorithm(ESynthFilterAlgorithm FilterAlgorithm) {}
	///<summary>Sets whether not stereo delay is enabled.</summary>
	public  void SetStereoDelayIsEnabled(bool StereoDelayEnabled) {}
	///<summary>Sets whether not stereo delay is enabled.</summary>
	public  void SetStereoDelayMode(ESynthStereoDelayMode StereoDelayMode) {}
	///<summary>Sets the amount of stereo delay time in msec.</summary>
	public  void SetStereoDelayTime(float DelayTimeMsec) {}
	///<summary>Sets the amount of stereo delay feedback [0.0, 1.0]</summary>
	public  void SetStereoDelayFeedback(float DelayFeedback) {}
	///<summary>Sets the amount of stereo delay wetlevel [0.0, 1.0]</summary>
	public  void SetStereoDelayWetlevel(float DelayWetlevel) {}
	///<summary>Sets the amount of stereo delay ratio between left and right delay lines [0.0, 1.0]</summary>
	public  void SetStereoDelayRatio(float DelayRatio) {}
	///<summary>Sets whether or not chorus is enabled.</summary>
	public  void SetChorusEnabled(bool EnableChorus) {}
	///<summary>Sets the chorus depth</summary>
	public  void SetChorusDepth(float Depth) {}
	///<summary>Sets the chorus feedback</summary>
	public  void SetChorusFeedback(float Feedback) {}
	///<summary>Sets the chorus frequency</summary>
	public  void SetChorusFrequency(float Frequency) {}
	///<summary>Sets the preset struct for the synth</summary>
	public  void SetSynthPreset(FModularSynthPreset SynthPreset) {}
	///<summary>Creates a new modular synth patch between a modulation source and a set of modulation destinations</summary>
	public  FPatchId CreatePatch(ESynth1PatchSource PatchSource,TArray<FSynth1PatchCable> PatchCables,bool bEnableByDefault) { return default; }
	///<summary>SetEnablePatch</summary>
	public  bool SetEnablePatch(FPatchId PatchId,bool bIsEnabled) { return default; }
}
