#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceController.h")]
public enum EMIDIEventType {
	Unknown=0,
	NoteOff=8,
	NoteOn=9,
	NoteAfterTouch=10,
	ControlChange=11,
	ProgramChange=12,
	ChannelAfterTouch=13,
	PitchBend=14,
}
