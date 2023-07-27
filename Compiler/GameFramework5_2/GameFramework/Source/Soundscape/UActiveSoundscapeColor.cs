#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeColor.h")]
public partial class UActiveSoundscapeColor : UObject {
// ActiveSoundscapeColor
	public  void OnSoundscapeColorParameterChange(USoundscapeColor SoundscapeColor) {}
	public USoundBase Sound;
	public FSoundscapeColorModulationSettings ModulationBehavior;
	public FSoundscapeColorPlaybackSettings PlaybackBehavior;
	public FSoundscapeColorSpawnSettings SpawnBehavior;
	public  void Play(float ColorVolume/*=1.0f*/,float ColorPitch/*=1.0f*/,float ColorFadeInTime/*=1.0f*/) {}
	public  void Stop(float ColorFadeOutTime/*=1.0f*/) {}
	public  bool IsPlaying() { return default; }
	public  void UpdateSoundscapeColor() {}
	public TArray<UActiveSoundscapeColorVoice> SoundscapeColorVoicePool;
}
