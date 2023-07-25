#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlProtocolMIDI.h")]
///<summary>MIDI protocol entity for remote control binding</summary>
public partial struct FRemoteControlMIDIProtocolEntity {
// RemoteControlMIDIProtocolEntity
	public FRemoteControlMIDIDevice Device;
	public EMIDIEventType EventType;
	public int MessageData1;
	public int Channel;
	public byte RangeInputTemplate;
}
