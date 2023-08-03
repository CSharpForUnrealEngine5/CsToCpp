#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AudioGameplayVolume - A spatial volume used to notify audio gameplay systems when the nearest audio listener</summary>
[CppInclude("AudioGameplayVolume.h")]
public partial class AAudioGameplayVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>A representation of this volume for the audio thread</summary>
	public UAudioGameplayVolumeComponent AGVComponent;
	///<summary>Whether this volume is currently enabled.  Disabled volumes will not have a volume proxy,</summary>
	public bool bEnabled;
	///<summary>Sets whether the volume is enabled</summary>
	public  void SetEnabled(bool bEnable) {}
	///<summary>Blueprint event for listener enter</summary>
	public  void OnListenerEnter() {}
	///<summary>Blueprint event for listener exit</summary>
	public  void OnListenerExit() {}
	///<summary>OnListenerEnterEvent</summary>
	public FAudioGameplayVolumeEvent OnListenerEnterEvent;
	///<summary>OnListenerExitEvent</summary>
	public FAudioGameplayVolumeEvent OnListenerExitEvent;
	///<summary>OnRep_bEnabled</summary>
	public  void OnRep_bEnabled() {}
}
