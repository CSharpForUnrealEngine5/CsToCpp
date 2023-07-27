#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceEditorBlueprintLibrary.h")]
public partial class ULevelSequenceEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// LevelSequenceEditorBlueprintLibrary
	public static bool OpenLevelSequence(ULevelSequence LevelSequence) { return default; }
	public static ULevelSequence GetCurrentLevelSequence() { return default; }
	public static ULevelSequence GetFocusedLevelSequence() { return default; }
	public static void FocusLevelSequence(UMovieSceneSubSection SubSection) {}
	public static void FocusParentSequence() {}
	public static TArray<UMovieSceneSubSection> GetSubSequenceHierarchy() { return default; }
	public static void CloseLevelSequence() {}
	public static void Play() {}
	public static void Pause() {}
	public static void SetCurrentTime(int NewFrame) {}
	public static int GetCurrentTime() { return default; }
	public static void SetCurrentLocalTime(int NewFrame) {}
	public static int GetCurrentLocalTime() { return default; }
	public static void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams) {}
	public static bool IsPlaying() { return default; }
	public static TArray<UMovieSceneTrack> GetSelectedTracks() { return default; }
	public static TArray<UMovieSceneSection> GetSelectedSections() { return default; }
	public static TArray<FSequencerChannelProxy> GetSelectedChannels() { return default; }
	public static TArray<UMovieSceneFolder> GetSelectedFolders() { return default; }
	public static TArray<FGuid> GetSelectedObjects() { return default; }
	public static TArray<FMovieSceneBindingProxy> GetSelectedBindings() { return default; }
	public static void SelectTracks(TArray<UMovieSceneTrack> Tracks) {}
	public static void SelectSections(TArray<UMovieSceneSection> Sections) {}
	public static void SelectChannels(TArray<FSequencerChannelProxy> Channels) {}
	public static void SelectFolders(TArray<UMovieSceneFolder> Folders) {}
	public static void SelectObjects(TArray<FGuid> ObjectBinding) {}
	public static void SelectBindings(TArray<FMovieSceneBindingProxy> ObjectBindings) {}
	public static void EmptySelection() {}
	public static void SetSelectionRangeStart(int NewFrame) {}
	public static void SetSelectionRangeEnd(int NewFrame) {}
	public static int GetSelectionRangeStart() { return default; }
	public static int GetSelectionRangeEnd() { return default; }
	public static void RefreshCurrentLevelSequence() {}
	public static TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	public static bool IsLevelSequenceLocked() { return default; }
	public static void SetLockLevelSequence(bool bLock) {}
	public static bool IsCameraCutLockedToViewport() { return default; }
	public static void SetLockCameraCutToViewport(bool bLock) {}
	public static bool IsTrackFilterEnabled(string TrackFilterName) { return default; }
	public static void SetTrackFilterEnabled(string TrackFilterName,bool bEnabled) {}
	public static TArray<string> GetTrackFilterNames() { return default; }
	public static bool HasCustomColorForChannel(UClass Class,string Identifier) { return default; }
	public static FLinearColor GetCustomColorForChannel(UClass Class,string Identifier) { return default; }
	public static void SetCustomColorForChannel(UClass Class,string Identifier,FLinearColor NewColor) {}
	public static void SetCustomColorForChannels(UClass Class,TArray<string> Identifiers,TArray<FLinearColor> NewColors) {}
	public static void SetRandomColorForChannels(UClass Class,TArray<string> Identifiers) {}
	public static void DeleteColorForChannels(UClass Class,string Identifier) {}
}
