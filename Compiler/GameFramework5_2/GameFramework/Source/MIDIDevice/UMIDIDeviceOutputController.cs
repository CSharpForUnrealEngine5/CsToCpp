#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceOutputController.h")]
public partial class UMIDIDeviceOutputController : UMIDIDeviceControllerBase {
	public static UClass StaticClass() {return default;}
	///<summary>Sends MIDI event raw data for an event type</summary>
	public  void SendMIDIEvent(EMIDIEventType EventType,int Channel,int data1,int data2) {}
	///<summary>Sends MIDI Note On event type</summary>
	public  void SendMIDINoteOn(int Channel,int Note,int Velocity) {}
	///<summary>Sends MIDI Note Off event type</summary>
	public  void SendMIDINoteOff(int Channel,int Note,int Velocity) {}
	///<summary>Sends MIDI Pitch Bend event type</summary>
	public  void SendMIDIPitchBend(int Channel,int Pitch) {}
	///<summary>Sends MIDI Note Aftertouch event type</summary>
	public  void SendMIDINoteAftertouch(int Channel,int Note,float Amount) {}
	///<summary>Sends MIDI Control Change event type</summary>
	public  void SendMIDIControlChange(int Channel,int Type,int Value) {}
	///<summary>Sends MIDI Program Change event type</summary>
	public  void SendMIDIProgramChange(int Channel,int ProgramNumber) {}
	///<summary>Sends MIDI Channel Aftertouch event type</summary>
	public  void SendMIDIChannelAftertouch(int Channel,float Amount) {}
	///<summary>The unique ID of this device</summary>
	public int DeviceID;
	///<summary>The name of this device.  This name comes from the MIDI hardware, any might not be unique</summary>
	public string DeviceName;
}
