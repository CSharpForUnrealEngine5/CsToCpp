namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for media sources that can be synchronized with the engine&#39;s timecode.</summary>
[CppInclude("TimeSynchronizableMediaSource.h")]
public partial class UTimeSynchronizableMediaSource : UBaseMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>Synchronize the media with the engine&#39;s timecode.</summary>
	public bool bUseTimeSynchronization;
	///<summary>When using Time Synchronization, how many frame back should it read.</summary>
	public int FrameDelay;
	///<summary>When not using Time Synchronization, how far back it time should it read.</summary>
	public double TimeDelay;
	///<summary>Whether to autodetect the input or not.</summary>
	public bool bAutoDetectInput;
}
