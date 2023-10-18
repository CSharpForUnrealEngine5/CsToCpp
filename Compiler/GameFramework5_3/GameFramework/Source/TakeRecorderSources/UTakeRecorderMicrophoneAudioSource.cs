namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source that records microphone audio</summary>
[CppInclude("TakeRecorderMicrophoneAudioSource.h")]
public partial class UTakeRecorderMicrophoneAudioSource : UTakeRecorderMicrophoneAudioSourceSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Gain in decibels to apply to recorded audio</summary>
	public float AudioGain;
	///<summary>bSplitAudioChannelsIntoSeparateTracks_DEPRECATED</summary>
	public bool bSplitAudioChannelsIntoSeparateTracks_DEPRECATED;
	///<summary>Replace existing recorded audio with any newly recorded audio</summary>
	public bool bReplaceRecordedAudio;
	///<summary>The audio device to use for this microphone source</summary>
	public FAudioInputDeviceChannelProperty AudioChannel;
}
