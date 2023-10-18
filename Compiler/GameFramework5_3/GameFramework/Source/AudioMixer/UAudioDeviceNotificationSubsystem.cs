namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioDeviceNotificationSubsystem</summary>
[CppInclude("AudioDeviceNotificationSubsystem.h")]
public partial class UAudioDeviceNotificationSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Multicast delegate triggered when default capture device changes</summary>
	public FOnAudioDefaultDeviceChanged DefaultCaptureDeviceChanged;
	///<summary>Multicast delegate triggered when default render device changes</summary>
	public FOnAudioDefaultDeviceChanged DefaultRenderDeviceChanged;
	///<summary>Multicast delegate triggered when a device is added</summary>
	public FOnAudioDeviceChange DeviceAdded;
	///<summary>Multicast delegate triggered when a device is removed</summary>
	public FOnAudioDeviceChange DeviceRemoved;
	///<summary>Multicast delegate triggered on device state change</summary>
	public FOnAudioDeviceStateChanged DeviceStateChanged;
	///<summary>Multicast delegate triggered on device switch</summary>
	public FOnAudioDeviceChange DeviceSwitched;
}
