namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceManager.h")]
public partial struct FMIDIDeviceInfo {
	public int DeviceID;
	public string DeviceName;
	public bool bIsAlreadyInUse;
	public bool bIsDefaultDevice;
}
