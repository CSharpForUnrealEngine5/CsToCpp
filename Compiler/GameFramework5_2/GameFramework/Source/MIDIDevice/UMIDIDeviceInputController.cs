#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceInputController.h")]
public partial class UMIDIDeviceInputController : UMIDIDeviceControllerBase {
// MIDIDeviceInputController
	public FOnMIDINoteOn OnMIDINoteOn;
	public FOnMIDINoteOff OnMIDINoteOff;
	public FOnMIDIPitchBend OnMIDIPitchBend;
	public FOnMIDIAftertouch OnMIDIAftertouch;
	public FOnMIDIControlChange OnMIDIControlChange;
	public FOnMIDIProgramChange OnMIDIProgramChange;
	public FOnMIDIChannelAftertouch OnMIDIChannelAftertouch;
	public int DeviceID;
	public string DeviceName;
}
