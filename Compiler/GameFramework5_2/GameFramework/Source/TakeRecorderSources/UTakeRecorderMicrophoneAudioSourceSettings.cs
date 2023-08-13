namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source that records microphone audio</summary>
[CppInclude("TakeRecorderMicrophoneAudioSource.h")]
public partial class UTakeRecorderMicrophoneAudioSourceSettings : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the recorded audio track</summary>
	public FText AudioTrackName;
	///<summary>The name of the audio asset.</summary>
	public string AudioAssetName;
	///<summary>The name of the subdirectory audio will be placed in. Leave this empty to place into the same directory as the sequence base path</summary>
	public string AudioSubDirectory;
}
