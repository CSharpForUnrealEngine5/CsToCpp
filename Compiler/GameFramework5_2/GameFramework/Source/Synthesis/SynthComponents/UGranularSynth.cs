#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentGranulator.h")]
public partial class UGranularSynth : USynthComponent {
	///<summary>This will override the current sound wave if one is set, stop audio, and reload the new sound wave</summary>
	public  void SetSoundWave(USoundWave InSoundWave) {}
	///<summary>SetAttackTime</summary>
	public  void SetAttackTime(float AttackTimeMsec) {}
	///<summary>SetDecayTime</summary>
	public  void SetDecayTime(float DecayTimeMsec) {}
	///<summary>SetSustainGain</summary>
	public  void SetSustainGain(float SustainGain) {}
	///<summary>SetReleaseTimeMsec</summary>
	public  void SetReleaseTimeMsec(float ReleaseTimeMsec) {}
	///<summary>NoteOn</summary>
	public  void NoteOn(float Note,int Velocity,float Duration/*=-1.0f*/) {}
	///<summary>NoteOff</summary>
	public  void NoteOff(float Note,bool bKill/*=false*/) {}
	///<summary>SetGrainsPerSecond</summary>
	public  void SetGrainsPerSecond(float InGrainsPerSecond) {}
	///<summary>SetGrainProbability</summary>
	public  void SetGrainProbability(float InGrainProbability) {}
	///<summary>SetGrainEnvelopeType</summary>
	public  void SetGrainEnvelopeType(EGranularSynthEnvelopeType EnvelopeType) {}
	///<summary>SetPlaybackSpeed</summary>
	public  void SetPlaybackSpeed(float InPlayheadRate) {}
	///<summary>SetGrainPitch</summary>
	public  void SetGrainPitch(float BasePitch,FVector2D PitchRange/*=FVector2D.ZeroVector*/) {}
	///<summary>SetGrainVolume</summary>
	public  void SetGrainVolume(float BaseVolume,FVector2D VolumeRange/*=FVector2D.ZeroVector*/) {}
	///<summary>SetGrainPan</summary>
	public  void SetGrainPan(float BasePan,FVector2D PanRange/*=FVector2D.ZeroVector*/) {}
	///<summary>SetGrainDuration</summary>
	public  void SetGrainDuration(float BaseDurationMsec,FVector2D DurationRange/*=FVector2D.ZeroVector*/) {}
	///<summary>GetSampleDuration</summary>
	public  float GetSampleDuration() { return default; }
	///<summary>SetScrubMode</summary>
	public  void SetScrubMode(bool bScrubMode) {}
	///<summary>SetPlayheadTime</summary>
	public  void SetPlayheadTime(float InPositionSec,float LerpTimeSec/*=0.0f*/,EGranularSynthSeekType SeekType/*=EGranularSynthSeekType.FromBeginning*/) {}
	///<summary>GetCurrentPlayheadTime</summary>
	public  float GetCurrentPlayheadTime() { return default; }
	///<summary>IsLoaded</summary>
	public  bool IsLoaded() { return default; }
	///<summary>GranulatedSoundWave</summary>
	public USoundWave GranulatedSoundWave;
}
