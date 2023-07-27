#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextToSpeechEngineSubsystem.h")]
///<summary>Subsystem for interacting with the text to speech system via blueprints.</summary>
public partial class UTextToSpeechEngineSubsystem : UEngineSubsystem {
// TextToSpeechEngineSubsystem
	public  void SpeakOnChannel(string InChannelId,string InStringToSpeak) {}
	public  void StopSpeakingOnChannel(string InChannelId) {}
	public  void StopSpeakingOnAllChannels() {}
	public  bool IsSpeakingOnChannel(string InChannelId) { return default; }
	public  float GetVolumeOnChannel(string InChannelId) { return default; }
	public  void SetVolumeOnChannel(string InChannelId,float InVolume) {}
	public  float GetRateOnChannel(string InChannelId) { return default; }
	public  void SetRateOnChannel(string InChannelId,float InRate) {}
	public  void MuteChannel(string InChannelId) {}
	public  void UnmuteChannel(string InChannelId) {}
	public  bool IsChannelMuted(string InChannelId) { return default; }
	public  void ActivateChannel(string InChannelId) {}
	public  void ActivateAllChannels() {}
	public  void DeactivateChannel(string InChannelId) {}
	public  void DeactivateAllChannels() {}
	public  bool IsChannelActive(string InChannelId) { return default; }
	public  void AddDefaultChannel(string InNewChannelId) {}
	public  void AddCustomChannel(string InNewChannelId) {}
	public  void RemoveChannel(string InChannelId) {}
	public  void RemoveAllChannels() {}
	public  bool DoesChannelExist(string InChannelId) { return default; }
	public  int GetNumChannels() { return default; }
}
