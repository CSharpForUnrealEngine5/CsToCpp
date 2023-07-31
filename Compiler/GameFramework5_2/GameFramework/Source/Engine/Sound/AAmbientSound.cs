#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A sound actor that can be placed in a level</summary>
[CppInclude("Sound/AmbientSound.h")]
public partial class AAmbientSound : AActor {
	///<summary>Audio component that handles sound playing</summary>
	public UAudioComponent AudioComponent;
	///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
	public  void FadeIn(float FadeInDuration,float FadeVolumeLevel/*=1.0f*/) {}
	///<summary>FadeOut</summary>
	public  void FadeOut(float FadeOutDuration,float FadeVolumeLevel) {}
	///<summary>AdjustVolume</summary>
	public  void AdjustVolume(float AdjustVolumeDuration,float AdjustVolumeLevel) {}
	///<summary>Play</summary>
	public  void Play(float StartTime/*=0.0f*/) {}
	///<summary>Stop</summary>
	public  void Stop() {}
}
