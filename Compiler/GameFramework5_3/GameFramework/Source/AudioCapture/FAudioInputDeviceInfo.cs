namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Platform audio input device info, in a Blueprint-readable format</summary>
[CppInclude("AudioCaptureBlueprintLibrary.h")]
public partial struct FAudioInputDeviceInfo {
	public string DeviceName;
	public string DeviceId;
	public int InputChannels;
	public int PreferredSampleRate;
	public bool bSupportsHardwareAEC;
}
