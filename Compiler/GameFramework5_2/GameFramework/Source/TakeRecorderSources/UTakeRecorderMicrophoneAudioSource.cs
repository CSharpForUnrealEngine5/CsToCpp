namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source that records microphone audio</summary>
[CppInclude("TakeRecorderMicrophoneAudioSource.h")]
public partial class UTakeRecorderMicrophoneAudioSource : UTakeRecorderMicrophoneAudioSourceSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Gain in decibels to apply to recorded audio</summary>
	public float AudioGain;
	///<summary>Whether or not to split mic channels into separate audio tracks. If not true, a max of 2 input channels is supported.</summary>
	public bool bSplitAudioChannelsIntoSeparateTracks;
	///<summary>Replace existing recorded audio with any newly recorded audio</summary>
	public bool bReplaceRecordedAudio;
}
