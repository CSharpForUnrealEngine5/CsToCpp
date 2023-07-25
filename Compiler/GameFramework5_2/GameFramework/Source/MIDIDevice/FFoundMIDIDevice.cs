#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceManager.h")]
public partial struct FFoundMIDIDevice {
// FoundMIDIDevice
	public int DeviceID;
	public string DeviceName;
	public bool bCanReceiveFrom;
	public bool bCanSendTo;
	public bool bIsAlreadyInUse;
	public bool bIsDefaultInputDevice;
	public bool bIsDefaultOutputDevice;
}
