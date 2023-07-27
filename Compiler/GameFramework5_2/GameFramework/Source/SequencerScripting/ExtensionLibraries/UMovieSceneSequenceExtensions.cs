#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneSequenceExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneSequences for scripting purposes</summary>
public partial class UMovieSceneSequenceExtensions : UBlueprintFunctionLibrary {
// MovieSceneSequenceExtensions
	public static UMovieScene GetMovieScene(UMovieSceneSequence Sequence) { return default; }
	public static TArray<UMovieSceneTrack> GetTracks(UMovieSceneSequence Sequence) { return default; }
	public static TArray<UMovieSceneTrack> GetMasterTracks(UMovieSceneSequence Sequence) { return default; }
	public static TArray<UMovieSceneTrack> FindTracksByType(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	public static TArray<UMovieSceneTrack> FindMasterTracksByType(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	public static TArray<UMovieSceneTrack> FindTracksByExactType(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	public static TArray<UMovieSceneTrack> FindMasterTracksByExactType(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	public static UMovieSceneTrack AddTrack(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	public static UMovieSceneTrack AddMasterTrack(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	public static bool RemoveTrack(UMovieSceneSequence Sequence,UMovieSceneTrack Track) { return default; }
	public static bool RemoveMasterTrack(UMovieSceneSequence Sequence,UMovieSceneTrack Track) { return default; }
	public static FFrameRate GetDisplayRate(UMovieSceneSequence Sequence) { return default; }
	public static void SetDisplayRate(UMovieSceneSequence Sequence,FFrameRate DisplayRate) {}
	public static FFrameRate GetTickResolution(UMovieSceneSequence Sequence) { return default; }
	public static void SetTickResolution(UMovieSceneSequence Sequence,FFrameRate TickResolution) {}
	public static void SetTickResolutionDirectly(UMovieSceneSequence Sequence,FFrameRate TickResolution) {}
	public static FSequencerScriptingRange MakeRange(UMovieSceneSequence Sequence,int StartFrame,int Duration) { return default; }
	public static FSequencerScriptingRange MakeRangeSeconds(UMovieSceneSequence Sequence,float StartTime,float Duration) { return default; }
	public static FSequencerScriptingRange GetPlaybackRange(UMovieSceneSequence Sequence) { return default; }
	public static int GetPlaybackStart(UMovieSceneSequence Sequence) { return default; }
	public static float GetPlaybackStartSeconds(UMovieSceneSequence Sequence) { return default; }
	public static int GetPlaybackEnd(UMovieSceneSequence Sequence) { return default; }
	public static float GetPlaybackEndSeconds(UMovieSceneSequence Sequence) { return default; }
	public static void SetPlaybackStart(UMovieSceneSequence Sequence,int StartFrame) {}
	public static void SetPlaybackStartSeconds(UMovieSceneSequence Sequence,float StartTime) {}
	public static void SetPlaybackEnd(UMovieSceneSequence Sequence,int EndFrame) {}
	public static void SetPlaybackEndSeconds(UMovieSceneSequence Sequence,float EndTime) {}
	public static void SetViewRangeStart(UMovieSceneSequence InSequence,float StartTimeInSeconds) {}
	public static float GetViewRangeStart(UMovieSceneSequence InSequence) { return default; }
	public static void SetViewRangeEnd(UMovieSceneSequence InSequence,float EndTimeInSeconds) {}
	public static float GetViewRangeEnd(UMovieSceneSequence InSequence) { return default; }
	public static void SetWorkRangeStart(UMovieSceneSequence InSequence,float StartTimeInSeconds) {}
	public static float GetWorkRangeStart(UMovieSceneSequence InSequence) { return default; }
	public static void SetWorkRangeEnd(UMovieSceneSequence InSequence,float EndTimeInSeconds) {}
	public static float GetWorkRangeEnd(UMovieSceneSequence InSequence) { return default; }
	public static void SetEvaluationType(UMovieSceneSequence InSequence,EMovieSceneEvaluationType InEvaluationType) {}
	public static EMovieSceneEvaluationType GetEvaluationType(UMovieSceneSequence InSequence) { return default; }
	public static void SetClockSource(UMovieSceneSequence InSequence,EUpdateClockSource InClockSource) {}
	public static EUpdateClockSource GetClockSource(UMovieSceneSequence InSequence) { return default; }
	public static FTimecode GetTimecodeSource(UMovieSceneSequence Sequence) { return default; }
	public static FMovieSceneBindingProxy FindBindingByName(UMovieSceneSequence Sequence,string Name) { return default; }
	public static FMovieSceneBindingProxy FindBindingById(UMovieSceneSequence Sequence,FGuid BindingId) { return default; }
	public static TArray<FMovieSceneBindingProxy> GetBindings(UMovieSceneSequence Sequence) { return default; }
	public static TArray<FMovieSceneBindingProxy> GetSpawnables(UMovieSceneSequence Sequence) { return default; }
	public static TArray<FMovieSceneBindingProxy> GetPossessables(UMovieSceneSequence Sequence) { return default; }
	public static FMovieSceneBindingProxy AddPossessable(UMovieSceneSequence Sequence,UObject ObjectToPossess) { return default; }
	public static FMovieSceneBindingProxy AddSpawnableFromInstance(UMovieSceneSequence Sequence,UObject ObjectToSpawn) { return default; }
	public static FMovieSceneBindingProxy AddSpawnableFromClass(UMovieSceneSequence Sequence,UClass ClassToSpawn) { return default; }
	public static TArray<UObject> LocateBoundObjects(UMovieSceneSequence Sequence,FMovieSceneBindingProxy InBinding,UObject Context) { return default; }
	public static FMovieSceneObjectBindingID MakeBindingID(UMovieSceneSequence Sequence,FMovieSceneBindingProxy InBinding,EMovieSceneObjectBindingSpace Space/*=EMovieSceneObjectBindingSpace.Root*/) { return default; }
	public static FMovieSceneObjectBindingID GetBindingID(FMovieSceneBindingProxy InBinding) { return default; }
	public static FMovieSceneObjectBindingID GetPortableBindingID(UMovieSceneSequence RootSequence,UMovieSceneSequence DestinationSequence,FMovieSceneBindingProxy InBinding) { return default; }
	public static FMovieSceneBindingProxy ResolveBindingID(UMovieSceneSequence RootSequence,FMovieSceneObjectBindingID InObjectBindingID) { return default; }
	public static TArray<UMovieSceneFolder> GetRootFoldersInSequence(UMovieSceneSequence Sequence) { return default; }
	public static UMovieSceneFolder AddRootFolderToSequence(UMovieSceneSequence Sequence,string NewFolderName) { return default; }
	public static void RemoveRootFolderFromSequence(UMovieSceneSequence Sequence,UMovieSceneFolder Folder) {}
	public static TArray<FMovieSceneMarkedFrame> GetMarkedFrames(UMovieSceneSequence Sequence) { return default; }
	public static int AddMarkedFrame(UMovieSceneSequence Sequence,FMovieSceneMarkedFrame InMarkedFrame) { return default; }
	public static void SetMarkedFrame(UMovieSceneSequence Sequence,int InMarkIndex,FFrameNumber InFrameNumber) {}
	public static void DeleteMarkedFrame(UMovieSceneSequence Sequence,int DeleteIndex) {}
	public static void DeleteMarkedFrames(UMovieSceneSequence Sequence) {}
	public static void SortMarkedFrames(UMovieSceneSequence Sequence) {}
	public static int FindMarkedFrameByLabel(UMovieSceneSequence Sequence,string InLabel) { return default; }
	public static int FindMarkedFrameByFrameNumber(UMovieSceneSequence Sequence,FFrameNumber InFrameNumber) { return default; }
	public static int FindNextMarkedFrame(UMovieSceneSequence Sequence,FFrameNumber InFrameNumber,bool bForward) { return default; }
	public static void SetReadOnly(UMovieSceneSequence Sequence,bool bInReadOnly) {}
	public static bool IsReadOnly(UMovieSceneSequence Sequence) { return default; }
}
