#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/CacheTrackRecorder.h")]
public partial class UCacheTrackRecorder : UObject {
// CacheTrackRecorder
	public float GetCountdownSeconds() { return default; }
	public UObject GetSequence() { return default; }
	public ECacheTrackRecorderState GetState() { return default; }
	public ULevelSequence SequenceAsset;
	public TWeakObjectPtr<UWorld> WeakWorld;
	public FCacheRecorderParameters Parameters;
	public TArray<FCachedTrackSource> CacheTracks;
}
