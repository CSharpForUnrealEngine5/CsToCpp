#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/CacheTrackRecorder.h")]
public enum ECacheTrackRecorderState {
	CountingDown=0,
	PreRecord=1,
	TickingAfterPre=2,
	Started=3,
	Stopped=4,
	Cancelled=5,
}
