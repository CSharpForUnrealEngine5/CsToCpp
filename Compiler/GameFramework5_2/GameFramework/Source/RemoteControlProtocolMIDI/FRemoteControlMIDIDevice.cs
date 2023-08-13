namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MIDI protocol device identifier</summary>
[CppInclude("RemoteControlProtocolMIDI.h")]
public partial struct FRemoteControlMIDIDevice {
	public ERemoteControlMIDIDeviceSelector DeviceSelector;
	public int ResolvedDeviceId;
	public string DeviceName;
	public int DeviceId;
	public bool bDeviceIsAvailable;
}
