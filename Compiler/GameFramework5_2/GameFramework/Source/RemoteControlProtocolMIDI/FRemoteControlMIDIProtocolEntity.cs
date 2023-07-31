#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MIDI protocol entity for remote control binding</summary>
[CppInclude("RemoteControlProtocolMIDI.h")]
public partial struct FRemoteControlMIDIProtocolEntity {
	public FRemoteControlMIDIDevice Device;
	public EMIDIEventType EventType;
	public int MessageData1;
	public int Channel;
	public byte RangeInputTemplate;
}
