namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULevelSequenceEditorSubsystem</summary>
[CppInclude("LevelSequenceEditorSubsystem.h")]
public partial class ULevelSequenceEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Retrieve the outliner</summary>
	public USequencerScriptingLayer GetScriptingLayer() { return default; }
	///<summary>Add existing actors to Sequencer. Tracks will be automatically added based on default track settings.</summary>
	public TArray<FMovieSceneBindingProxy> AddActors(TArray<AActor> Actors) { return default; }
	///<summary>Create a cine camera actor and add it to Sequencer</summary>
	public FMovieSceneBindingProxy CreateCamera(bool bSpawnable,ACineCameraActor OutActor) { return default; }
	///<summary>Convert to spawnable. If there are multiple objects assigned to the possessable, multiple spawnables will be created.</summary>
	public TArray<FMovieSceneBindingProxy> ConvertToSpawnable(FMovieSceneBindingProxy ObjectBinding) { return default; }
	///<summary>Convert to possessable</summary>
	public FMovieSceneBindingProxy ConvertToPossessable(FMovieSceneBindingProxy ObjectBinding) { return default; }
	///<summary>Copy folders</summary>
	public void CopyFolders(TArray<UMovieSceneFolder> Folders,string ExportedText) {}
	///<summary>Paste folders</summary>
	public bool PasteFolders(string TextToImport,FMovieScenePasteFoldersParams PasteFoldersParams,TArray<UMovieSceneFolder> OutFolders) { return default; }
	///<summary>Copy sections</summary>
	public void CopySections(TArray<UMovieSceneSection> Sections,string ExportedText) {}
	///<summary>Paste sections</summary>
	public bool PasteSections(string TextToImport,FMovieScenePasteSectionsParams PasteSectionsParams,TArray<UMovieSceneSection> OutSections) { return default; }
	///<summary>Copy tracks</summary>
	public void CopyTracks(TArray<UMovieSceneTrack> Tracks,string ExportedText) {}
	///<summary>Paste tracks</summary>
	public bool PasteTracks(string TextToImport,FMovieScenePasteTracksParams PasteTracksParams,TArray<UMovieSceneTrack> OutTracks) { return default; }
	///<summary>Copy bindings</summary>
	public void CopyBindings(TArray<FMovieSceneBindingProxy> Bindings,string ExportedText) {}
	///<summary>Paste bindings</summary>
	public bool PasteBindings(string TextToImport,FMovieScenePasteBindingsParams PasteBindingsParams,TArray<FMovieSceneBindingProxy> OutObjectBindings) { return default; }
	///<summary>Snap sections to timeline using source timecode</summary>
	public void SnapSectionsToTimelineUsingSourceTimecode(TArray<UMovieSceneSection> Sections) {}
	///<summary>Sync section using source timecode</summary>
	public void SyncSectionsUsingSourceTimecode(TArray<UMovieSceneSection> Sections) {}
	///<summary>BakeTransform</summary>
	public void BakeTransform(TArray<FMovieSceneBindingProxy> ObjectBindings,FFrameTime BakeInTime,FFrameTime BakeOutTime,FFrameTime BakeInterval,FMovieSceneScriptingParams Params/*=new FMovieSceneScriptingParams()*/) {}
	///<summary>BakeTransformWithSettings</summary>
	public bool BakeTransformWithSettings(TArray<FMovieSceneBindingProxy> ObjectBindings,FBakingAnimationKeySettings InSettings,FMovieSceneScriptingParams Params/*=new FMovieSceneScriptingParams()*/) { return default; }
	///<summary>Attempts to automatically fix up broken actor references in the current scene</summary>
	public void FixActorReferences() {}
	///<summary>Assigns the given actors to the binding</summary>
	public void AddActorsToBinding(TArray<AActor> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	///<summary>Replaces the binding with the given actors</summary>
	public void ReplaceBindingWithActors(TArray<AActor> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	///<summary>Removes the given actors from the binding</summary>
	public void RemoveActorsFromBinding(TArray<AActor> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	///<summary>Remove all bound actors from this track</summary>
	public void RemoveAllBindings(FMovieSceneBindingProxy ObjectBinding) {}
	///<summary>Remove missing objects bound to this track</summary>
	public void RemoveInvalidBindings(FMovieSceneBindingProxy ObjectBinding) {}
	///<summary>Rebind the component binding to the requested component</summary>
	public void RebindComponent(TArray<FMovieSceneBindingProxy> ComponentBindings,FName ComponentName) {}
}
