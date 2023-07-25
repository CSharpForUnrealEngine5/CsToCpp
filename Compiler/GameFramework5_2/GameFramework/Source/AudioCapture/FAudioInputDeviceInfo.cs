#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioCaptureBlueprintLibrary.h")]
///<summary>Platform audio input device info, in a Blueprint-readable format</summary>
public partial struct FAudioInputDeviceInfo {
// AudioInputDeviceInfo
	public string DeviceName;
	public string DeviceId;
	public int InputChannels;
	public int PreferredSampleRate;
	public bool bSupportsHardwareAEC;
}
