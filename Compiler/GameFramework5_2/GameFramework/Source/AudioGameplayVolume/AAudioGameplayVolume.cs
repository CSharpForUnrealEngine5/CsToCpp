#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioGameplayVolume.h")]
///<summary>AudioGameplayVolume - A spatial volume used to notify audio gameplay systems when the nearest audio listener</summary>
public partial class AAudioGameplayVolume : AVolume {
// AudioGameplayVolume
	public UAudioGameplayVolumeComponent AGVComponent;
	public bool bEnabled;
	public  void SetEnabled(bool bEnable) {}
	public  void OnListenerEnter() {}
	public  void OnListenerExit() {}
	public FAudioGameplayVolumeEvent OnListenerEnterEvent;
	public FAudioGameplayVolumeEvent OnListenerExitEvent;
	public  void OnRep_bEnabled() {}
}
