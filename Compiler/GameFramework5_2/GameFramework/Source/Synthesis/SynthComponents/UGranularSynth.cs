#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentGranulator.h")]
public partial class UGranularSynth : USynthComponent {
// GranularSynth
	public  void SetSoundWave(USoundWave InSoundWave) {}
	public  void SetAttackTime(float AttackTimeMsec) {}
	public  void SetDecayTime(float DecayTimeMsec) {}
	public  void SetSustainGain(float SustainGain) {}
	public  void SetReleaseTimeMsec(float ReleaseTimeMsec) {}
	public  void NoteOn(float Note,int Velocity,float Duration/*=-1.0f*/) {}
	public  void NoteOff(float Note,bool bKill/*=false*/) {}
	public  void SetGrainsPerSecond(float InGrainsPerSecond) {}
	public  void SetGrainProbability(float InGrainProbability) {}
	public  void SetGrainEnvelopeType(EGranularSynthEnvelopeType EnvelopeType) {}
	public  void SetPlaybackSpeed(float InPlayheadRate) {}
	public  void SetGrainPitch(float BasePitch,FVector2D PitchRange/*=FVector2D.ZeroVector*/) {}
	public  void SetGrainVolume(float BaseVolume,FVector2D VolumeRange/*=FVector2D.ZeroVector*/) {}
	public  void SetGrainPan(float BasePan,FVector2D PanRange/*=FVector2D.ZeroVector*/) {}
	public  void SetGrainDuration(float BaseDurationMsec,FVector2D DurationRange/*=FVector2D.ZeroVector*/) {}
	public  float GetSampleDuration() { return default; }
	public  void SetScrubMode(bool bScrubMode) {}
	public  void SetPlayheadTime(float InPositionSec,float LerpTimeSec/*=0.0f*/,EGranularSynthSeekType SeekType/*=EGranularSynthSeekType.FromBeginning*/) {}
	public  float GetCurrentPlayheadTime() { return default; }
	public  bool IsLoaded() { return default; }
	public USoundWave GranulatedSoundWave;
}
