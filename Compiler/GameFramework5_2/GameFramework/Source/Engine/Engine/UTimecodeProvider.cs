#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TimecodeProvider.h")]
///<summary>A class responsible of fetching a timecode from a source.</summary>
public partial class UTimecodeProvider : UObject {
// TimecodeProvider
	public float FrameDelay;
	public bool FetchTimecode(FQualifiedFrameTime OutFrameTime) { return default; }
	public void FetchAndUpdate() {}
	public FQualifiedFrameTime GetQualifiedFrameTime() { return default; }
	public FQualifiedFrameTime GetDelayedQualifiedFrameTime() { return default; }
	public FTimecode GetTimecode() { return default; }
	public FTimecode GetDelayedTimecode() { return default; }
	public FFrameRate GetFrameRate() { return default; }
	public ETimecodeProviderSynchronizationState GetSynchronizationState() { return default; }
}
