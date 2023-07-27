#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceOutputController.h")]
public partial class UMIDIDeviceOutputController : UMIDIDeviceControllerBase {
// MIDIDeviceOutputController
	public  void SendMIDIEvent(EMIDIEventType EventType,int Channel,int data1,int data2) {}
	public  void SendMIDINoteOn(int Channel,int Note,int Velocity) {}
	public  void SendMIDINoteOff(int Channel,int Note,int Velocity) {}
	public  void SendMIDIPitchBend(int Channel,int Pitch) {}
	public  void SendMIDINoteAftertouch(int Channel,int Note,float Amount) {}
	public  void SendMIDIControlChange(int Channel,int Type,int Value) {}
	public  void SendMIDIProgramChange(int Channel,int ProgramNumber) {}
	public  void SendMIDIChannelAftertouch(int Channel,float Amount) {}
	public int DeviceID;
	public string DeviceName;
}
