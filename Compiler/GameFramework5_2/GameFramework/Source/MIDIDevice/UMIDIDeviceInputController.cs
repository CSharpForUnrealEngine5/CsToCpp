#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceInputController.h")]
public partial class UMIDIDeviceInputController : UMIDIDeviceControllerBase {
	///<summary>Register with this to receive incoming MIDI Note On events from this device</summary>
	public FOnMIDINoteOn OnMIDINoteOn;
	///<summary>Register with this to receive incoming MIDI Note Off events from this device</summary>
	public FOnMIDINoteOff OnMIDINoteOff;
	///<summary>Register with this to receive incoming MIDI Pitch Bend events from this device</summary>
	public FOnMIDIPitchBend OnMIDIPitchBend;
	///<summary>Register with this to receive incoming MIDI Aftertouch events from this device</summary>
	public FOnMIDIAftertouch OnMIDIAftertouch;
	///<summary>Register with this to receive incoming MIDI Control Change events from this device</summary>
	public FOnMIDIControlChange OnMIDIControlChange;
	///<summary>Register with this to receive incoming MIDI Program Change events from this device</summary>
	public FOnMIDIProgramChange OnMIDIProgramChange;
	///<summary>Register with this to receive incoming MIDI Channel Aftertouch events from this device</summary>
	public FOnMIDIChannelAftertouch OnMIDIChannelAftertouch;
	///<summary>The unique ID of this device</summary>
	public int DeviceID;
	///<summary>The name of this device.  This name comes from the MIDI hardware, any might not be unique</summary>
	public string DeviceName;
}
