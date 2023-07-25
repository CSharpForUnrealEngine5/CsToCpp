#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceEditorSubsystem.h")]
///<summary>ULevelSequenceEditorSubsystem</summary>
public partial class ULevelSequenceEditorSubsystem : UEditorSubsystem {
// LevelSequenceEditorSubsystem
	public TArray<FMovieSceneBindingProxy> AddActors(TArray<UObject> Actors) { return default; }
	public FMovieSceneBindingProxy CreateCamera(bool bSpawnable,UObject OutActor) { return default; }
	public TArray<FMovieSceneBindingProxy> ConvertToSpawnable(FMovieSceneBindingProxy ObjectBinding) { return default; }
	public FMovieSceneBindingProxy ConvertToPossessable(FMovieSceneBindingProxy ObjectBinding) { return default; }
	public void CopyFolders(TArray<UObject> Folders,string ExportedText) {}
	public bool PasteFolders(string TextToImport,FMovieScenePasteFoldersParams PasteFoldersParams,TArray<UObject> OutFolders) { return default; }
	public void CopySections(TArray<UObject> Sections,string ExportedText) {}
	public bool PasteSections(string TextToImport,FMovieScenePasteSectionsParams PasteSectionsParams,TArray<UObject> OutSections) { return default; }
	public void CopyTracks(TArray<UObject> Tracks,string ExportedText) {}
	public bool PasteTracks(string TextToImport,FMovieScenePasteTracksParams PasteTracksParams,TArray<UObject> OutTracks) { return default; }
	public void CopyBindings(TArray<FMovieSceneBindingProxy> Bindings,string ExportedText) {}
	public bool PasteBindings(string TextToImport,FMovieScenePasteBindingsParams PasteBindingsParams,TArray<FMovieSceneBindingProxy> OutObjectBindings) { return default; }
	public void SnapSectionsToTimelineUsingSourceTimecode(TArray<UObject> Sections) {}
	public void SyncSectionsUsingSourceTimecode(TArray<UObject> Sections) {}
	public void BakeTransform(TArray<FMovieSceneBindingProxy> ObjectBindings,FFrameTime BakeInTime,FFrameTime BakeOutTime,FFrameTime BakeInterval,FMovieSceneScriptingParams Params/*=new FMovieSceneScriptingParams()*/) {}
	public void FixActorReferences() {}
	public void AddActorsToBinding(TArray<UObject> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	public void ReplaceBindingWithActors(TArray<UObject> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	public void RemoveActorsFromBinding(TArray<UObject> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	public void RemoveAllBindings(FMovieSceneBindingProxy ObjectBinding) {}
	public void RemoveInvalidBindings(FMovieSceneBindingProxy ObjectBinding) {}
	public void RebindComponent(TArray<FMovieSceneBindingProxy> ComponentBindings,string ComponentName) {}
}
