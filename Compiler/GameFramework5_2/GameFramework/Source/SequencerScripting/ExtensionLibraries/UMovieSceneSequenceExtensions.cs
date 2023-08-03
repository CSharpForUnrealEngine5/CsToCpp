#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto UMovieSceneSequences for scripting purposes</summary>
[CppInclude("ExtensionLibraries/MovieSceneSequenceExtensions.h")]
public partial class UMovieSceneSequenceExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get this sequence&#39;s movie scene data</summary>
	public static UMovieScene GetMovieScene(UMovieSceneSequence Sequence) { return default; }
	///<summary>Get all tracks</summary>
	public static TArray<UMovieSceneTrack> GetTracks(UMovieSceneSequence Sequence) { return default; }
	///<summary>GetMasterTracks</summary>
	public static TArray<UMovieSceneTrack> GetMasterTracks(UMovieSceneSequence Sequence) { return default; }
	///<summary>Find all tracks of the specified type</summary>
	public static TArray<UMovieSceneTrack> FindTracksByType(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	///<summary>FindMasterTracksByType</summary>
	public static TArray<UMovieSceneTrack> FindMasterTracksByType(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	///<summary>Find all tracks of the specified type, not allowing sub-classed types</summary>
	public static TArray<UMovieSceneTrack> FindTracksByExactType(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	///<summary>FindMasterTracksByExactType</summary>
	public static TArray<UMovieSceneTrack> FindMasterTracksByExactType(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	///<summary>Add a new track of the specified type</summary>
	public static UMovieSceneTrack AddTrack(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	///<summary>AddMasterTrack</summary>
	public static UMovieSceneTrack AddMasterTrack(UMovieSceneSequence Sequence,UClass TrackType) { return default; }
	///<summary>Removes a track</summary>
	public static bool RemoveTrack(UMovieSceneSequence Sequence,UMovieSceneTrack Track) { return default; }
	///<summary>RemoveMasterTrack</summary>
	public static bool RemoveMasterTrack(UMovieSceneSequence Sequence,UMovieSceneTrack Track) { return default; }
	///<summary>Gets this sequence&#39;s display rate</summary>
	public static FFrameRate GetDisplayRate(UMovieSceneSequence Sequence) { return default; }
	///<summary>Sets this sequence&#39;s display rate</summary>
	public static void SetDisplayRate(UMovieSceneSequence Sequence,FFrameRate DisplayRate) {}
	///<summary>Gets this sequence&#39;s tick resolution</summary>
	public static FFrameRate GetTickResolution(UMovieSceneSequence Sequence) { return default; }
	///<summary>Sets this sequence&#39;s tick resolution and migrates frame times</summary>
	public static void SetTickResolution(UMovieSceneSequence Sequence,FFrameRate TickResolution) {}
	///<summary>Sets this sequence&#39;s tick resolution directly without migrating frame times</summary>
	public static void SetTickResolutionDirectly(UMovieSceneSequence Sequence,FFrameRate TickResolution) {}
	///<summary>Make a new range for this sequence in its display rate</summary>
	public static FSequencerScriptingRange MakeRange(UMovieSceneSequence Sequence,int StartFrame,int Duration) { return default; }
	///<summary>Make a new range for this sequence in seconds</summary>
	public static FSequencerScriptingRange MakeRangeSeconds(UMovieSceneSequence Sequence,float StartTime,float Duration) { return default; }
	///<summary>Get playback range of this sequence in display rate resolution</summary>
	public static FSequencerScriptingRange GetPlaybackRange(UMovieSceneSequence Sequence) { return default; }
	///<summary>Get playback start of this sequence in display rate resolution</summary>
	public static int GetPlaybackStart(UMovieSceneSequence Sequence) { return default; }
	///<summary>Get playback start of this sequence in seconds</summary>
	public static float GetPlaybackStartSeconds(UMovieSceneSequence Sequence) { return default; }
	///<summary>Get playback end of this sequence in display rate resolution</summary>
	public static int GetPlaybackEnd(UMovieSceneSequence Sequence) { return default; }
	///<summary>Get playback end of this sequence in seconds</summary>
	public static float GetPlaybackEndSeconds(UMovieSceneSequence Sequence) { return default; }
	///<summary>Set playback start of this sequence</summary>
	public static void SetPlaybackStart(UMovieSceneSequence Sequence,int StartFrame) {}
	///<summary>Set playback start of this sequence in seconds</summary>
	public static void SetPlaybackStartSeconds(UMovieSceneSequence Sequence,float StartTime) {}
	///<summary>Set playback end of this sequence</summary>
	public static void SetPlaybackEnd(UMovieSceneSequence Sequence,int EndFrame) {}
	///<summary>Set playback end of this sequence in seconds</summary>
	public static void SetPlaybackEndSeconds(UMovieSceneSequence Sequence,float EndTime) {}
	///<summary>Set the sequence view range start in seconds</summary>
	public static void SetViewRangeStart(UMovieSceneSequence InSequence,float StartTimeInSeconds) {}
	///<summary>Get the sequence view range start in seconds</summary>
	public static float GetViewRangeStart(UMovieSceneSequence InSequence) { return default; }
	///<summary>Set the sequence view range end in seconds</summary>
	public static void SetViewRangeEnd(UMovieSceneSequence InSequence,float EndTimeInSeconds) {}
	///<summary>Get the sequence view range end in seconds</summary>
	public static float GetViewRangeEnd(UMovieSceneSequence InSequence) { return default; }
	///<summary>Set the sequence work range start in seconds</summary>
	public static void SetWorkRangeStart(UMovieSceneSequence InSequence,float StartTimeInSeconds) {}
	///<summary>Get the sequence work range start in seconds</summary>
	public static float GetWorkRangeStart(UMovieSceneSequence InSequence) { return default; }
	///<summary>Set the sequence work range end in seconds</summary>
	public static void SetWorkRangeEnd(UMovieSceneSequence InSequence,float EndTimeInSeconds) {}
	///<summary>Get the sequence work range end in seconds</summary>
	public static float GetWorkRangeEnd(UMovieSceneSequence InSequence) { return default; }
	///<summary>Set the evaluation type for this sequence</summary>
	public static void SetEvaluationType(UMovieSceneSequence InSequence,EMovieSceneEvaluationType InEvaluationType) {}
	///<summary>Get the evaluation type for this sequence</summary>
	public static EMovieSceneEvaluationType GetEvaluationType(UMovieSceneSequence InSequence) { return default; }
	///<summary>Set the clock source for this sequence</summary>
	public static void SetClockSource(UMovieSceneSequence InSequence,EUpdateClockSource InClockSource) {}
	///<summary>Get the clock source for this sequence</summary>
	public static EUpdateClockSource GetClockSource(UMovieSceneSequence InSequence) { return default; }
	///<summary>GetTimecodeSource</summary>
	public static FTimecode GetTimecodeSource(UMovieSceneSequence Sequence) { return default; }
	///<summary>Attempt to locate a binding in this sequence by its name</summary>
	public static FMovieSceneBindingProxy FindBindingByName(UMovieSceneSequence Sequence,string Name) { return default; }
	///<summary>Attempt to locate a binding in this sequence by its Id</summary>
	public static FMovieSceneBindingProxy FindBindingById(UMovieSceneSequence Sequence,FGuid BindingId) { return default; }
	///<summary>Get all the bindings in this sequence</summary>
	public static TArray<FMovieSceneBindingProxy> GetBindings(UMovieSceneSequence Sequence) { return default; }
	///<summary>Get all the spawnables in this sequence</summary>
	public static TArray<FMovieSceneBindingProxy> GetSpawnables(UMovieSceneSequence Sequence) { return default; }
	///<summary>Get all the possessables in this sequence</summary>
	public static TArray<FMovieSceneBindingProxy> GetPossessables(UMovieSceneSequence Sequence) { return default; }
	///<summary>Add a new binding to this sequence that will possess the specified object</summary>
	public static FMovieSceneBindingProxy AddPossessable(UMovieSceneSequence Sequence,UObject ObjectToPossess) { return default; }
	///<summary>Add a new binding to this sequence that will spawn the specified object</summary>
	public static FMovieSceneBindingProxy AddSpawnableFromInstance(UMovieSceneSequence Sequence,UObject ObjectToSpawn) { return default; }
	///<summary>Add a new binding to this sequence that will spawn the specified object</summary>
	public static FMovieSceneBindingProxy AddSpawnableFromClass(UMovieSceneSequence Sequence,UClass ClassToSpawn) { return default; }
	///<summary>Locate all the objects that correspond to the specified object ID, using the specified context</summary>
	public static TArray<UObject> LocateBoundObjects(UMovieSceneSequence Sequence,FMovieSceneBindingProxy InBinding,UObject Context) { return default; }
	///<summary>MakeBindingID</summary>
	public static FMovieSceneObjectBindingID MakeBindingID(UMovieSceneSequence Sequence,FMovieSceneBindingProxy InBinding,EMovieSceneObjectBindingSpace Space/*=EMovieSceneObjectBindingSpace.Root*/) { return default; }
	///<summary>Get the binding ID for a binding within a sequence.</summary>
	public static FMovieSceneObjectBindingID GetBindingID(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Get a portable binding ID for a binding that resides in a different sequence to the one where this binding will be resolved.</summary>
	public static FMovieSceneObjectBindingID GetPortableBindingID(UMovieSceneSequence RootSequence,UMovieSceneSequence DestinationSequence,FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Make a binding for the given binding ID</summary>
	public static FMovieSceneBindingProxy ResolveBindingID(UMovieSceneSequence RootSequence,FMovieSceneObjectBindingID InObjectBindingID) { return default; }
	///<summary>Get the root folders in the provided sequence</summary>
	public static TArray<UMovieSceneFolder> GetRootFoldersInSequence(UMovieSceneSequence Sequence) { return default; }
	///<summary>Add a root folder to the given sequence</summary>
	public static UMovieSceneFolder AddRootFolderToSequence(UMovieSceneSequence Sequence,string NewFolderName) { return default; }
	///<summary>Remove a root folder from the given sequence. Will throw an exception if the specified folder is not valid or not a root folder.</summary>
	public static void RemoveRootFolderFromSequence(UMovieSceneSequence Sequence,UMovieSceneFolder Folder) {}
	///<summary>* @return Return the user marked frames</summary>
	public static TArray<FMovieSceneMarkedFrame> GetMarkedFrames(UMovieSceneSequence Sequence) { return default; }
	///<summary>* Add a given user marked frame.</summary>
	public static int AddMarkedFrame(UMovieSceneSequence Sequence,FMovieSceneMarkedFrame InMarkedFrame) { return default; }
	///<summary>* Sets the frame number for the given marked frame index. Does not maintain sort. Call SortMarkedFrames</summary>
	public static void SetMarkedFrame(UMovieSceneSequence Sequence,int InMarkIndex,FFrameNumber InFrameNumber) {}
	///<summary>* Delete the user marked frame by index.</summary>
	public static void DeleteMarkedFrame(UMovieSceneSequence Sequence,int DeleteIndex) {}
	///<summary>* Delete all user marked frames</summary>
	public static void DeleteMarkedFrames(UMovieSceneSequence Sequence) {}
	///<summary>* Sort the marked frames in chronological order</summary>
	public static void SortMarkedFrames(UMovieSceneSequence Sequence) {}
	///<summary>* Find the user marked frame by label</summary>
	public static int FindMarkedFrameByLabel(UMovieSceneSequence Sequence,string InLabel) { return default; }
	///<summary>* Find the user marked frame by frame number</summary>
	public static int FindMarkedFrameByFrameNumber(UMovieSceneSequence Sequence,FFrameNumber InFrameNumber) { return default; }
	///<summary>* Find the next/previous user marked frame from the given frame number</summary>
	public static int FindNextMarkedFrame(UMovieSceneSequence Sequence,FFrameNumber InFrameNumber,bool bForward) { return default; }
	///<summary>* Set read only</summary>
	public static void SetReadOnly(UMovieSceneSequence Sequence,bool bInReadOnly) {}
	///<summary>* Is read only</summary>
	public static bool IsReadOnly(UMovieSceneSequence Sequence) { return default; }
}
