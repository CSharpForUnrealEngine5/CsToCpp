namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Encapsulates audio device properties which are utilized by UI facing classes such as FAudioInputDeviceProperty.</summary>
[CppInclude("TakeRecorderSourceProperty.h")]
public partial struct FAudioInputDeviceInfoProperty {
	public string DeviceName;
	public string DeviceId;
	public int InputChannels;
	public int PreferredSampleRate;
	public bool bIsDefaultDevice;
}
