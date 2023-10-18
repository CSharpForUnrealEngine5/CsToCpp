namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorder.h")]
public enum ETakeRecorderState {
	CountingDown=0,
	PreRecord=1,
	TickingAfterPre=2,
	Started=3,
	Stopped=4,
	Cancelled=5,
}
