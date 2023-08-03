#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/CacheTrackRecorder.h")]
public partial class UCacheTrackRecorder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Access the number of seconds remaining before this recording will start</summary>
	public  float GetCountdownSeconds() { return default; }
	///<summary>Access the sequence asset that this recorder is recording into</summary>
	public  ULevelSequence GetSequence() { return default; }
	///<summary>Get the current state of this recorder</summary>
	public  ECacheTrackRecorderState GetState() { return default; }
	///<summary>The asset that we should output recorded data into</summary>
	public ULevelSequence SequenceAsset;
	///<summary>The world that we are recording within</summary>
	public TWeakObjectPtr<UWorld> WeakWorld;
	///<summary>Parameters for the recorder - marked up as a uproperty to support reference collection</summary>
	public FCacheRecorderParameters Parameters;
	///<summary>CacheTracks</summary>
	public TArray<FCachedTrackSource> CacheTracks;
}
