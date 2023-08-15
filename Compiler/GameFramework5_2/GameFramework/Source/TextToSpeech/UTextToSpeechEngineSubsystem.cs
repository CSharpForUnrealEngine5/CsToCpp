namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystem for interacting with the text to speech system via blueprints.</summary>
[CppInclude("TextToSpeechEngineSubsystem.h")]
public partial class UTextToSpeechEngineSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Immediately vocalizes the requested string asynchronously on the requested text to speech channel, interrupting any string that is already being vocalized on the channel.</summary>
	public void SpeakOnChannel(FName InChannelId,string InStringToSpeak) {}
	///<summary>Immediately stops any currently vocalized string on the channel.</summary>
	public void StopSpeakingOnChannel(FName InChannelId) {}
	///<summary>Immediately stops strings from being vocalized on all text to speech channels.</summary>
	public void StopSpeakingOnAllChannels() {}
	///<summary>Return true when the targeted text to speech channel is vocalising, otherwise false.</summary>
	public bool IsSpeakingOnChannel(FName InChannelId) { return default; }
	///<summary>Returns the current volume strings are vocalized on a text to speech channel.  Value is between 0.0f and 1.0f.</summary>
	public float GetVolumeOnChannel(FName InChannelId) { return default; }
	///<summary>Sets the volume for strings vocalized on a text to speech channel.</summary>
	public void SetVolumeOnChannel(FName InChannelId,float InVolume) {}
	///<summary>Returns the current speech rate strings are vocalized on a text to speech channel. Value is between 0.0 and 1.0.</summary>
	public float GetRateOnChannel(FName InChannelId) { return default; }
	///<summary>Sets the current speech rate strings should be vocalized on a text to speech channel.</summary>
	public void SetRateOnChannel(FName InChannelId,float InRate) {}
	///<summary>Mutes a text to speech channel so no vocalized strings are audible on that channel.</summary>
	public void MuteChannel(FName InChannelId) {}
	///<summary>Unmutes a text to speech channel so vocalized strings are audible on the channel.</summary>
	public void UnmuteChannel(FName InChannelId) {}
	///<summary>Returns true if the text to speech channel is muted, otherwise false.</summary>
	public bool IsChannelMuted(FName InChannelId) { return default; }
	///<summary>Activates a text to speech channel to accept requests to perform text to speech functionality.</summary>
	public void ActivateChannel(FName InChannelId) {}
	///<summary>Activates all text to speech channels to accept requests for text to speech functionality.</summary>
	public void ActivateAllChannels() {}
	///<summary>Deactivates a text to speech channel and stops any vocalized strings on that channel. Future Requests for text to speech functionality will do nothing.</summary>
	public void DeactivateChannel(FName InChannelId) {}
	///<summary>Deactivates all text to speech channels making all requests for text to speech functionality do nothing.</summary>
	public void DeactivateAllChannels() {}
	///<summary>Returns true if the text to speech channel is active, otherwise false.</summary>
	public bool IsChannelActive(FName InChannelId) { return default; }
	///<summary>Creates a new  channel for text to speech requests to be made to a platform C++ text to speech class.</summary>
	public void AddDefaultChannel(FName InNewChannelId) {}
	///<summary>Creates a new text to speech channel where text to speech requests are fulfilled by a user implemented C++ text to speech class.</summary>
	public void AddCustomChannel(FName InNewChannelId) {}
	///<summary>Removes a text to speech channel, preventing all further requests for text to speech functionality from the channel.</summary>
	public void RemoveChannel(FName InChannelId) {}
	///<summary>Removes all text to speech channels, preventin future requests for text to speech functionality on all channels.</summary>
	public void RemoveAllChannels() {}
	///<summary>Returns true if a text to speech channel associated with a channel Id exists. Otherwise, the function returns false.</summary>
	public bool DoesChannelExist(FName InChannelId) { return default; }
	///<summary>Returns the number of text to speech channels that have been added.</summary>
	public int GetNumChannels() { return default; }
}
