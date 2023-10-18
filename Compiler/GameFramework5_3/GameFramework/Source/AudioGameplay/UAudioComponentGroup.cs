namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Automatic Handler for voices and parameters across any number of AudioComponents</summary>
[CppInclude("AudioComponentGroup.h")]
public partial class UAudioComponentGroup : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>StaticGetOrCreateComponentGroup</summary>
	public static UAudioComponentGroup StaticGetOrCreateComponentGroup(AActor Actor) { return default; }
	///<summary>Stop all instances of this Sound on any internal or external components</summary>
	public void StopSound(USoundBase Sound,float FadeTime/*=0.0f*/) {}
	///<summary>IsPlayingAny</summary>
	public bool IsPlayingAny() { return default; }
	///<summary>IsVirtualized</summary>
	public bool IsVirtualized() { return default; }
	///<summary>BroadcastStopAll</summary>
	public void BroadcastStopAll() {}
	///<summary>BroadcastKill</summary>
	public void BroadcastKill() {}
	///<summary>BroadcastEvent</summary>
	public void BroadcastEvent(FName EventName) {}
	///<summary>Allow an externally created AudioComponent to share parameters with this SoundGroup</summary>
	public void AddExternalComponent(UAudioComponent ComponentToAdd) {}
	///<summary>EnableVirtualization</summary>
	public void EnableVirtualization() {}
	///<summary>DisableVirtualization</summary>
	public void DisableVirtualization() {}
	///<summary>SetVolumeMultiplier</summary>
	public void SetVolumeMultiplier(float InVolume) {}
	///<summary>SetPitchMultiplier</summary>
	public void SetPitchMultiplier(float InPitch) {}
	///<summary>SetLowPassFilter</summary>
	public void SetLowPassFilter(float InFrequency) {}
	///<summary>AddExtension</summary>
	public void AddExtension(object /*NewExtension*/ NewExtension) {}
	///<summary>RemoveExtension</summary>
	public void RemoveExtension(object /*NewExtension*/ NewExtension) {}
	///<summary>GetFloatParamValue</summary>
	public float GetFloatParamValue(FName ParamName) { return default; }
	///<summary>GetBoolParamValue</summary>
	public bool GetBoolParamValue(FName ParamName) { return default; }
	///<summary>GetStringParamValue</summary>
	public string GetStringParamValue(FName ParamName) { return default; }
	///<summary>SubscribeToStringParam</summary>
	public void SubscribeToStringParam(FName ParamName,FStringParamCallback Delegate) {}
	///<summary>SubscribeToEvent</summary>
	public void SubscribeToEvent(FName EventName,FSoundCallback Delegate) {}
	///<summary>SubscribeToBool</summary>
	public void SubscribeToBool(FName ParamName,FBoolParamCallback Delegate) {}
	///<summary>remove any string, event, and bool subscriptions that are bound to this object</summary>
	public void UnsubscribeObject(UObject Object) {}
	///<summary>OnStopped</summary>
	public FSoundGroupChanged OnStopped;
	///<summary>OnKilled</summary>
	public FSoundGroupChanged OnKilled;
	///<summary>OnVirtualized</summary>
	public FSoundGroupChanged OnVirtualized;
	///<summary>OnUnvirtualized</summary>
	public FSoundGroupChanged OnUnvirtualized;
	///<summary>Components</summary>
	public TArray<UAudioComponent> Components;
	///<summary>ParamsToSet</summary>
	public TArray<FAudioParameter> ParamsToSet;
	///<summary>PersistentParams</summary>
	public TArray<FAudioParameter> PersistentParams;
	///<summary>Extensions</summary>
	public TArray<object /*Extensions*/> Extensions;
}
