#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceEditorBlueprintLibrary.h")]
public partial class ULevelSequenceEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// LevelSequenceEditorBlueprintLibrary
	public bool OpenLevelSequence(UObject LevelSequence) { return default; }
	public UObject GetCurrentLevelSequence() { return default; }
	public UObject GetFocusedLevelSequence() { return default; }
	public void FocusLevelSequence(UObject SubSection) {}
	public void FocusParentSequence() {}
	public TArray<UObject> GetSubSequenceHierarchy() { return default; }
	public void CloseLevelSequence() {}
	public void Play() {}
	public void Pause() {}
	public void SetCurrentTime(int NewFrame) {}
	public int GetCurrentTime() { return default; }
	public void SetCurrentLocalTime(int NewFrame) {}
	public int GetCurrentLocalTime() { return default; }
	public void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams) {}
	public bool IsPlaying() { return default; }
	public TArray<UObject> GetSelectedTracks() { return default; }
	public TArray<UObject> GetSelectedSections() { return default; }
	public TArray<FSequencerChannelProxy> GetSelectedChannels() { return default; }
	public TArray<UObject> GetSelectedFolders() { return default; }
	public TArray<FGuid> GetSelectedObjects() { return default; }
	public TArray<FMovieSceneBindingProxy> GetSelectedBindings() { return default; }
	public void SelectTracks(TArray<UObject> Tracks) {}
	public void SelectSections(TArray<UObject> Sections) {}
	public void SelectChannels(TArray<FSequencerChannelProxy> Channels) {}
	public void SelectFolders(TArray<UObject> Folders) {}
	public void SelectObjects(TArray<FGuid> ObjectBinding) {}
	public void SelectBindings(TArray<FMovieSceneBindingProxy> ObjectBindings) {}
	public void EmptySelection() {}
	public void SetSelectionRangeStart(int NewFrame) {}
	public void SetSelectionRangeEnd(int NewFrame) {}
	public int GetSelectionRangeStart() { return default; }
	public int GetSelectionRangeEnd() { return default; }
	public void RefreshCurrentLevelSequence() {}
	public TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	public bool IsLevelSequenceLocked() { return default; }
	public void SetLockLevelSequence(bool bLock) {}
	public bool IsCameraCutLockedToViewport() { return default; }
	public void SetLockCameraCutToViewport(bool bLock) {}
	public bool IsTrackFilterEnabled(string TrackFilterName) { return default; }
	public void SetTrackFilterEnabled(string TrackFilterName,bool bEnabled) {}
	public TArray<string> GetTrackFilterNames() { return default; }
	public bool HasCustomColorForChannel(UClass Class,string Identifier) { return default; }
	public FLinearColor GetCustomColorForChannel(UClass Class,string Identifier) { return default; }
	public void SetCustomColorForChannel(UClass Class,string Identifier,FLinearColor NewColor) {}
	public void SetCustomColorForChannels(UClass Class,TArray<string> Identifiers,TArray<FLinearColor> NewColors) {}
	public void SetRandomColorForChannels(UClass Class,TArray<string> Identifiers) {}
	public void DeleteColorForChannels(UClass Class,string Identifier) {}
}
