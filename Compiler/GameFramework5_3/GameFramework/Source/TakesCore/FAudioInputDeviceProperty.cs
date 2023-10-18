namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Encapsulates the array of audio input devices which is populated by UTakeRecorderMicrophoneAudioManager and</summary>
[CppInclude("TakeRecorderSourceProperty.h")]
public partial struct FAudioInputDeviceProperty {
	public bool bUseSystemDefaultAudioDevice;
	public TArray<FAudioInputDeviceInfoProperty> DeviceInfoArray;
	public string DeviceId;
	public int AudioInputBufferSize;
}
