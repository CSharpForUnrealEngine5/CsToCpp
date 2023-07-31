#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentWaveTable.h")]
public partial class USynthSamplePlayer : USynthComponent {
	///<summary>SoundWave</summary>
	public USoundWave SoundWave;
	///<summary>OnSampleLoaded</summary>
	public FOnSampleLoaded OnSampleLoaded;
	///<summary>OnSamplePlaybackProgress</summary>
	public FOnSamplePlaybackProgress OnSamplePlaybackProgress;
	///<summary>This will override the current sound wave if one is set, stop audio, and reload the new sound wave</summary>
	public  void SetSoundWave(USoundWave InSoundWave) {}
	///<summary>SetPitch</summary>
	public  void SetPitch(float InPitch,float TimeSec) {}
	///<summary>SeekToTime</summary>
	public  void SeekToTime(float TimeSec,ESamplePlayerSeekType SeekType,bool bWrap/*=true*/) {}
	///<summary>SetScrubMode</summary>
	public  void SetScrubMode(bool bScrubMode) {}
	///<summary>SetScrubTimeWidth</summary>
	public  void SetScrubTimeWidth(float InScrubTimeWidthSec) {}
	///<summary>GetSampleDuration</summary>
	public  float GetSampleDuration() { return default; }
	///<summary>GetCurrentPlaybackProgressTime</summary>
	public  float GetCurrentPlaybackProgressTime() { return default; }
	///<summary>GetCurrentPlaybackProgressPercent</summary>
	public  float GetCurrentPlaybackProgressPercent() { return default; }
	///<summary>IsLoaded</summary>
	public  bool IsLoaded() { return default; }
}
