#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentWaveTable.h")]
public partial class USynthSamplePlayer : USynthComponent {
// SynthSamplePlayer
	public USoundWave SoundWave;
	public FOnSampleLoaded OnSampleLoaded;
	public FOnSamplePlaybackProgress OnSamplePlaybackProgress;
	public void SetSoundWave(UObject InSoundWave) {}
	public void SetPitch(float InPitch,float TimeSec) {}
	public void SeekToTime(float TimeSec,ESamplePlayerSeekType SeekType,bool bWrap/*=true*/) {}
	public void SetScrubMode(bool bScrubMode) {}
	public void SetScrubTimeWidth(float InScrubTimeWidthSec) {}
	public float GetSampleDuration() { return default; }
	public float GetCurrentPlaybackProgressTime() { return default; }
	public float GetCurrentPlaybackProgressPercent() { return default; }
	public bool IsLoaded() { return default; }
}
