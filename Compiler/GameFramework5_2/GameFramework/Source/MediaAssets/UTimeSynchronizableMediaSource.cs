#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimeSynchronizableMediaSource.h")]
///<summary>Base class for media sources that can be synchronized with the engine's timecode.</summary>
public partial class UTimeSynchronizableMediaSource : UBaseMediaSource {
// TimeSynchronizableMediaSource
	public bool bUseTimeSynchronization;
	public int FrameDelay;
	public double TimeDelay;
	public bool bAutoDetectInput;
}
