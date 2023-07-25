#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/CacheTrackRecorder.h")]
///<summary>Structure housing all configurable parameters for a take recorder instance</summary>
public partial struct FCacheRecorderParameters {
// CacheRecorderParameters
	public FCacheRecorderUserParameters User;
	public FCacheRecorderProjectParameters Project;
	public FFrameNumber StartFrame;
}
