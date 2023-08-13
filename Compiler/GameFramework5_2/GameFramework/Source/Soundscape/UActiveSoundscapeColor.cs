namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeColor.h")]
public partial class UActiveSoundscapeColor : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Function bound to the Parameter change delegate</summary>
	public void OnSoundscapeColorParameterChange(USoundscapeColor SoundscapeColor) {}
	///<summary>Sound to Play</summary>
	public USoundBase Sound;
	///<summary>Modulation behavior</summary>
	public FSoundscapeColorModulationSettings ModulationBehavior;
	///<summary>Playback behavior</summary>
	public FSoundscapeColorPlaybackSettings PlaybackBehavior;
	///<summary>Playback behavior</summary>
	public FSoundscapeColorSpawnSettings SpawnBehavior;
	///<summary>Play Active Soundscape Color</summary>
	public void Play(float ColorVolume/*=1.0f*/,float ColorPitch/*=1.0f*/,float ColorFadeInTime/*=1.0f*/) {}
	///<summary>Stop Active Soundscape Color</summary>
	public void Stop(float ColorFadeOutTime/*=1.0f*/) {}
	///<summary>Is playing</summary>
	public bool IsPlaying() { return default; }
	///<summary>Timer Update Call</summary>
	public void UpdateSoundscapeColor() {}
	///<summary>Audio Component Pool</summary>
	public TArray<UActiveSoundscapeColorVoice> SoundscapeColorVoicePool;
}
