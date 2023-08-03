#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceController.h")]
public partial class UMIDIDeviceController : UMIDIDeviceControllerBase {
	public static UClass StaticClass() {return default;}
	///<summary>Register with this to find out about incoming MIDI events from this device</summary>
	public FOnMIDIEvent OnMIDIEvent;
	///<summary>The unique ID of this device</summary>
	public int DeviceID;
	///<summary>The name of this device.  This name comes from the MIDI hardware, any might not be unique</summary>
	public string DeviceName;
}
