namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class exposes the audio input device list via the project settings details. It does this in</summary>
[CppInclude("TakeRecorderMicrophoneAudioManager.h")]
public partial class UTakeRecorderMicrophoneAudioManager : UTakeRecorderAudioInputSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The audio device to use for this microphone source</summary>
	public FAudioInputDeviceProperty AudioInputDevice;
}
