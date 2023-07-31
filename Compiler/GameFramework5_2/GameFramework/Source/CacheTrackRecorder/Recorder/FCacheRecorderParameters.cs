#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure housing all configurable parameters for a take recorder instance</summary>
[CppInclude("Recorder/CacheTrackRecorder.h")]
public partial struct FCacheRecorderParameters {
	public FCacheRecorderUserParameters User;
	public FCacheRecorderProjectParameters Project;
	public FFrameNumber StartFrame;
}
