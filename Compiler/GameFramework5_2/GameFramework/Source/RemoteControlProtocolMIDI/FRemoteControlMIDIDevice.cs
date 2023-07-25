#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlProtocolMIDI.h")]
///<summary>MIDI protocol device identifier</summary>
public partial struct FRemoteControlMIDIDevice {
// RemoteControlMIDIDevice
	public ERemoteControlMIDIDeviceSelector DeviceSelector;
	public int ResolvedDeviceId;
	public string DeviceName;
	public int DeviceId;
	public bool bDeviceIsAvailable;
}
