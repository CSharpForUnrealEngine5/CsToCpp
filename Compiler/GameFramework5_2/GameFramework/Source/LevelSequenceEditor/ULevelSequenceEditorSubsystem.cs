#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceEditorSubsystem.h")]
///<summary>ULevelSequenceEditorSubsystem</summary>
public partial class ULevelSequenceEditorSubsystem : UEditorSubsystem {
// LevelSequenceEditorSubsystem
	public  TArray<FMovieSceneBindingProxy> AddActors(TArray<AActor> Actors) { return default; }
	public  FMovieSceneBindingProxy CreateCamera(bool bSpawnable,ACineCameraActor OutActor) { return default; }
	public  TArray<FMovieSceneBindingProxy> ConvertToSpawnable(FMovieSceneBindingProxy ObjectBinding) { return default; }
	public  FMovieSceneBindingProxy ConvertToPossessable(FMovieSceneBindingProxy ObjectBinding) { return default; }
	public  void CopyFolders(TArray<UMovieSceneFolder> Folders,string ExportedText) {}
	public  bool PasteFolders(string TextToImport,FMovieScenePasteFoldersParams PasteFoldersParams,TArray<UMovieSceneFolder> OutFolders) { return default; }
	public  void CopySections(TArray<UMovieSceneSection> Sections,string ExportedText) {}
	public  bool PasteSections(string TextToImport,FMovieScenePasteSectionsParams PasteSectionsParams,TArray<UMovieSceneSection> OutSections) { return default; }
	public  void CopyTracks(TArray<UMovieSceneTrack> Tracks,string ExportedText) {}
	public  bool PasteTracks(string TextToImport,FMovieScenePasteTracksParams PasteTracksParams,TArray<UMovieSceneTrack> OutTracks) { return default; }
	public  void CopyBindings(TArray<FMovieSceneBindingProxy> Bindings,string ExportedText) {}
	public  bool PasteBindings(string TextToImport,FMovieScenePasteBindingsParams PasteBindingsParams,TArray<FMovieSceneBindingProxy> OutObjectBindings) { return default; }
	public  void SnapSectionsToTimelineUsingSourceTimecode(TArray<UMovieSceneSection> Sections) {}
	public  void SyncSectionsUsingSourceTimecode(TArray<UMovieSceneSection> Sections) {}
	public  void BakeTransform(TArray<FMovieSceneBindingProxy> ObjectBindings,FFrameTime BakeInTime,FFrameTime BakeOutTime,FFrameTime BakeInterval,FMovieSceneScriptingParams Params/*=new FMovieSceneScriptingParams()*/) {}
	public  void FixActorReferences() {}
	public  void AddActorsToBinding(TArray<AActor> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	public  void ReplaceBindingWithActors(TArray<AActor> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	public  void RemoveActorsFromBinding(TArray<AActor> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	public  void RemoveAllBindings(FMovieSceneBindingProxy ObjectBinding) {}
	public  void RemoveInvalidBindings(FMovieSceneBindingProxy ObjectBinding) {}
	public  void RebindComponent(TArray<FMovieSceneBindingProxy> ComponentBindings,string ComponentName) {}
}
