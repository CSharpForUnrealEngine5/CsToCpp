#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentMonoWaveTable.h")]
public partial class USynthComponentMonoWaveTable : USynthComponent {
// SynthComponentMonoWaveTable
	public int GetNumTableEntries() { return default; }
	public void NoteOn(float InMidiNote,float InVelocity) {}
	public void NoteOff(float InMidiNote) {}
	public void SetSustainPedalState(bool InSustainPedalState) {}
	public void SetFrequency(float FrequencyHz) {}
	public void SetFrequencyPitchBend(float FrequencyOffsetCents) {}
	public void SetFrequencyWithMidiNote(float InMidiNote) {}
	public void SetWaveTablePosition(float InPosition) {}
	public void RefreshWaveTable(int Index) {}
	public void RefreshAllWaveTables() {}
	public void SetPosLfoFrequency(float InLfoFrequency) {}
	public void SetPosLfoDepth(float InLfoDepth) {}
	public void SetPosLfoType(ESynthLFOType InLfoType) {}
	public void SetLowPassFilterResonance(float InNewQ) {}
	public void SetAmpEnvelopeAttackTime(float InAttackTimeMsec) {}
	public void SetAmpEnvelopeDecayTime(float InDecayTimeMsec) {}
	public void SetAmpEnvelopeSustainGain(float InSustainGain) {}
	public void SetAmpEnvelopeReleaseTime(float InReleaseTimeMsec) {}
	public void SetAmpEnvelopeInvert(bool bInInvert) {}
	public void SetAmpEnvelopeBiasInvert(bool bInBiasInvert) {}
	public void SetAmpEnvelopeDepth(float InDepth) {}
	public void SetAmpEnvelopeBiasDepth(float InDepth) {}
	public void SetFilterEnvelopeAttackTime(float InAttackTimeMsec) {}
	public void SetFilterEnvelopenDecayTime(float InDecayTimeMsec) {}
	public void SetFilterEnvelopeSustainGain(float InSustainGain) {}
	public void SetFilterEnvelopeReleaseTime(float InReleaseTimeMsec) {}
	public void SetFilterEnvelopeInvert(bool bInInvert) {}
	public void SetFilterEnvelopeBiasInvert(bool bInBiasInvert) {}
	public void SetFilterEnvelopeDepth(float InDepth) {}
	public void SetFilterEnvelopeBiasDepth(float InDepth) {}
	public void SetPositionEnvelopeAttackTime(float InAttackTimeMsec) {}
	public void SetPositionEnvelopeDecayTime(float InDecayTimeMsec) {}
	public void SetPositionEnvelopeSustainGain(float InSustainGain) {}
	public void SetPositionEnvelopeReleaseTime(float InReleaseTimeMsec) {}
	public void SetPositionEnvelopeInvert(bool bInInvert) {}
	public void SetPositionEnvelopeBiasInvert(bool bInBiasInvert) {}
	public void SetPositionEnvelopeDepth(float InDepth) {}
	public void SetPositionEnvelopeBiasDepth(float InDepth) {}
	public int GetMaxTableIndex() { return default; }
	public bool SetCurveValue(int TableIndex,int KeyframeIndex,float NewValue) { return default; }
	public bool SetCurveInterpolationType(CurveInterpolationType InterpolationType,int TableIndex) { return default; }
	public bool SetCurveTangent(int TableIndex,float InNewTangent) { return default; }
	public float GetCurveTangent(int TableIndex) { return default; }
	public TArray<float> GetKeyFrameValuesForTable(float TableIndex) { return default; }
	public FOnTableAltered OnTableAltered;
	public FNumTablesChanged OnNumTablesChanged;
	public UMonoWaveTableSynthPreset CurrentPreset;
}
