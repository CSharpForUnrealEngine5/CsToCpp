#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioComponentGroup.h")]
///<summary>* Automatic Handler for voices and parameters across any number of AudioComponents</summary>
public partial class UAudioComponentGroup : USceneComponent {
// AudioComponentGroup
	public static UAudioComponentGroup StaticGetOrCreateComponentGroup(AActor Actor) { return default; }
	public  void StopSound(USoundBase Sound,float FadeTime/*=0.0f*/) {}
	public  bool IsPlayingAny() { return default; }
	public  bool IsVirtualized() { return default; }
	public  void BroadcastStopAll() {}
	public  void BroadcastKill() {}
	public  void BroadcastEvent(string EventName) {}
	public  void AddExternalComponent(UAudioComponent ComponentToAdd) {}
	public  void EnableVirtualization() {}
	public  void DisableVirtualization() {}
	public  void SetVolumeMultiplier(float InVolume) {}
	public  void SetPitchMultiplier(float InPitch) {}
	public  void SetLowPassFilter(float InFrequency) {}
	public  void AddExtension(object /*NewExtension*/ NewExtension) {}
	public  void RemoveExtension(object /*NewExtension*/ NewExtension) {}
	public  float GetFloatParamValue(string ParamName) { return default; }
	public  bool GetBoolParamValue(string ParamName) { return default; }
	public  string GetStringParamValue(string ParamName) { return default; }
	public FSoundGroupChanged OnStopped;
	public FSoundGroupChanged OnKilled;
	public FSoundGroupChanged OnVirtualized;
	public FSoundGroupChanged OnUnvirtualized;
	public TArray<UAudioComponent> Components;
	public TArray<FAudioParameter> ParamsToSet;
	public TArray<FAudioParameter> PersistentParams;
	public TArray<object /*Extensions*/> Extensions;
}
