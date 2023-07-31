#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A class responsible of fetching a timecode from a source.</summary>
[CppInclude("Engine/TimecodeProvider.h")]
public partial class UTimecodeProvider : UObject {
	///<summary>Number of frames to subtract from the qualified frame time when GetDelayedQualifiedFrameTime or GetDelayedTimecode is called.</summary>
	public float FrameDelay;
	///<summary>Fetch current timecode from its source. e.g. From hardware/network/file/etc.</summary>
	public  bool FetchTimecode(FQualifiedFrameTime OutFrameTime) { return default; }
	///<summary>Update the state of the provider. Call it to ensure timecode and state are updated.</summary>
	public  void FetchAndUpdate() {}
	///<summary>Return current frame time.</summary>
	public  FQualifiedFrameTime GetQualifiedFrameTime() { return default; }
	///<summary>Return current frame time with FrameDelay applied.</summary>
	public  FQualifiedFrameTime GetDelayedQualifiedFrameTime() { return default; }
	///<summary>Return the frame time converted into a timecode value.</summary>
	public  FTimecode GetTimecode() { return default; }
	///<summary>Return the delayed frame time converted into a timecode value.</summary>
	public  FTimecode GetDelayedTimecode() { return default; }
	///<summary>Return the frame rate of the frame time.</summary>
	public  FFrameRate GetFrameRate() { return default; }
	///<summary>The state of the TimecodeProvider and if it&#39;s currently synchronized and the Timecode and FrameRate getters are valid.</summary>
	public  ETimecodeProviderSynchronizationState GetSynchronizationState() { return default; }
}
