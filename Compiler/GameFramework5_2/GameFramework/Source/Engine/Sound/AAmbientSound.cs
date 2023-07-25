#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AmbientSound.h")]
///<summary>A sound actor that can be placed in a level</summary>
public partial class AAmbientSound : AActor {
// AmbientSound
	public UAudioComponent AudioComponent;
	public void FadeIn(float FadeInDuration,float FadeVolumeLevel/*=1.0f*/) {}
	public void FadeOut(float FadeOutDuration,float FadeVolumeLevel) {}
	public void AdjustVolume(float AdjustVolumeDuration,float AdjustVolumeLevel) {}
	public void Play(float StartTime/*=0.0f*/) {}
	public void Stop() {}
}
