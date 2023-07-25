#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioDeviceNotificationSubsystem.h")]
///<summary>UAudioDeviceNotificationSubsystem</summary>
public partial class UAudioDeviceNotificationSubsystem : UEngineSubsystem {
// AudioDeviceNotificationSubsystem
	public FOnAudioDefaultDeviceChanged DefaultCaptureDeviceChanged;
	public FOnAudioDefaultDeviceChanged DefaultRenderDeviceChanged;
	public FOnAudioDeviceChange DeviceAdded;
	public FOnAudioDeviceChange DeviceRemoved;
	public FOnAudioDeviceStateChanged DeviceStateChanged;
	public FOnAudioDeviceChange DeviceSwitched;
}
