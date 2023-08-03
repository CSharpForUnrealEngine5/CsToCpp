#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentMonoWaveTable.h")]
public partial class USynthComponentMonoWaveTable : USynthComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Start BP functionality // Get the number of table elements from Blueprint</summary>
	public  int GetNumTableEntries() { return default; }
	///<summary>Starts a new note (retrigs modulators, etc.)</summary>
	public  void NoteOn(float InMidiNote,float InVelocity) {}
	///<summary>Starts a new note (retrigs modulators, etc.)</summary>
	public  void NoteOff(float InMidiNote) {}
	///<summary>Inform the synth if the sustain pedal is pressed or not</summary>
	public  void SetSustainPedalState(bool InSustainPedalState) {}
	///<summary>Sets the oscillator&#39;s frequency</summary>
	public  void SetFrequency(float FrequencyHz) {}
	///<summary>Set a frequency offset in cents (for pitch modulation such as the Pitch Bend Wheel)</summary>
	public  void SetFrequencyPitchBend(float FrequencyOffsetCents) {}
	///<summary>Set the oscillator&#39;s frequency via midi note number</summary>
	public  void SetFrequencyWithMidiNote(float InMidiNote) {}
	///<summary>Sets the wavetable position. Expects a percentage between 0.0 and 1.0</summary>
	public  void SetWaveTablePosition(float InPosition) {}
	///<summary>Refresh a particular wavetable (from Game Thread data)</summary>
	public  void RefreshWaveTable(int Index) {}
	///<summary>Refresh all wavetables (from Game Thread data)</summary>
	public  void RefreshAllWaveTables() {}
	///<summary>Set frequency of LFO controlling Table Position (in Hz)</summary>
	public  void SetPosLfoFrequency(float InLfoFrequency) {}
	///<summary>Set the Modulation depth of the Lfo controlling the Table Position around the current position value</summary>
	public  void SetPosLfoDepth(float InLfoDepth) {}
	///<summary>Set the shape of the Lfo controlling the position</summary>
	public  void SetPosLfoType(ESynthLFOType InLfoType) {}
	///<summary>Set the Cut-off frequency of the low-pass filter</summary>
	public  void SetLowPassFilterResonance(float InNewQ) {}
	///<summary>Set Amp envelope attack time (msec)</summary>
	public  void SetAmpEnvelopeAttackTime(float InAttackTimeMsec) {}
	///<summary>Set Amp envelope decay time (msec)</summary>
	public  void SetAmpEnvelopeDecayTime(float InDecayTimeMsec) {}
	///<summary>Set Amp envelope sustain gain [0.0, 1.0]</summary>
	public  void SetAmpEnvelopeSustainGain(float InSustainGain) {}
	///<summary>Set Amp envelope release time (msec)</summary>
	public  void SetAmpEnvelopeReleaseTime(float InReleaseTimeMsec) {}
	///<summary>Set whether or not the Amp envelope is inverted</summary>
	public  void SetAmpEnvelopeInvert(bool bInInvert) {}
	///<summary>Set whether or not the Amp envelope&#39;s bias is inverted</summary>
	public  void SetAmpEnvelopeBiasInvert(bool bInBiasInvert) {}
	///<summary>Set the overall depth of the Amp envelope</summary>
	public  void SetAmpEnvelopeDepth(float InDepth) {}
	///<summary>Set the bias depth of the the Amp envelope</summary>
	public  void SetAmpEnvelopeBiasDepth(float InDepth) {}
	///<summary>Set Low-Pass Filter envelope attack time (msec)</summary>
	public  void SetFilterEnvelopeAttackTime(float InAttackTimeMsec) {}
	///<summary>Set Low-Pass Filter envelope decay time (msec)</summary>
	public  void SetFilterEnvelopenDecayTime(float InDecayTimeMsec) {}
	///<summary>Set Low-Pass Filter envelope sustain gain</summary>
	public  void SetFilterEnvelopeSustainGain(float InSustainGain) {}
	///<summary>Set Low-Pass Filter envelope release time (msec)</summary>
	public  void SetFilterEnvelopeReleaseTime(float InReleaseTimeMsec) {}
	///<summary>Set Low-Pass Filter envelope inversion</summary>
	public  void SetFilterEnvelopeInvert(bool bInInvert) {}
	///<summary>Set Low-Pass Filter envelope bias inversion</summary>
	public  void SetFilterEnvelopeBiasInvert(bool bInBiasInvert) {}
	///<summary>Set Low-Pass Filter envelope depth</summary>
	public  void SetFilterEnvelopeDepth(float InDepth) {}
	///<summary>Set Low-Pass Filter envelope bias depth</summary>
	public  void SetFilterEnvelopeBiasDepth(float InDepth) {}
	///<summary>Set Position envelope attack time (msec)</summary>
	public  void SetPositionEnvelopeAttackTime(float InAttackTimeMsec) {}
	///<summary>Set Position envelope decay time (msec)</summary>
	public  void SetPositionEnvelopeDecayTime(float InDecayTimeMsec) {}
	///<summary>Set Position envelope sustain gain</summary>
	public  void SetPositionEnvelopeSustainGain(float InSustainGain) {}
	///<summary>Set Position envelope release time (msec)</summary>
	public  void SetPositionEnvelopeReleaseTime(float InReleaseTimeMsec) {}
	///<summary>Set Position envelope envelope inversion</summary>
	public  void SetPositionEnvelopeInvert(bool bInInvert) {}
	///<summary>Set Position envelope bias inversion</summary>
	public  void SetPositionEnvelopeBiasInvert(bool bInBiasInvert) {}
	///<summary>Set Position envelope envelope depth</summary>
	public  void SetPositionEnvelopeDepth(float InDepth) {}
	///<summary>Set Position envelope bias depth</summary>
	public  void SetPositionEnvelopeBiasDepth(float InDepth) {}
	///<summary>Get the number of curves in the wave table. (returns -1 if there is no asset)</summary>
	public  int GetMaxTableIndex() { return default; }
	///<summary>Set a Keyframe value given a Table number and Keyframe number.</summary>
	public  bool SetCurveValue(int TableIndex,int KeyframeIndex,float NewValue) { return default; }
	///<summary>Set the curve interpolation type (What the curve is doing between keyframes)</summary>
	public  bool SetCurveInterpolationType(CurveInterpolationType InterpolationType,int TableIndex) { return default; }
	///<summary>Set the curve tangent (&quot;Curve depth&quot; between keyframes)</summary>
	public  bool SetCurveTangent(int TableIndex,float InNewTangent) { return default; }
	///<summary>Get the curve interpolation type (What the curve is doing between keyframes)</summary>
	public  float GetCurveTangent(int TableIndex) { return default; }
	///<summary>Get an array of floats that represent the key frames in the requested curve</summary>
	public  TArray<float> GetKeyFrameValuesForTable(float TableIndex) { return default; }
	///<summary>Wave Table curve was edited</summary>
	public FOnTableAltered OnTableAltered;
	///<summary>Curve array altered</summary>
	public FNumTablesChanged OnNumTablesChanged;
	///<summary>The settings asset to use for this synth</summary>
	public UMonoWaveTableSynthPreset CurrentPreset;
}
