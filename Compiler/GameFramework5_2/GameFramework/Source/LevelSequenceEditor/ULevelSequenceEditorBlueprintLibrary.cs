namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceEditorBlueprintLibrary.h")]
public partial class ULevelSequenceEditorBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>* Open a level sequence asset</summary>
	public static bool OpenLevelSequence(ULevelSequence LevelSequence) { return default; }
	///<summary>* Get the currently opened root level sequence asset</summary>
	public static ULevelSequence GetCurrentLevelSequence() { return default; }
	///<summary>* Get the currently focused/viewed level sequence asset if there is a hierarchy of sequences.</summary>
	public static ULevelSequence GetFocusedLevelSequence() { return default; }
	///<summary>* Focus/view the sequence associated to the given sub sequence section.</summary>
	public static void FocusLevelSequence(UMovieSceneSubSection SubSection) {}
	///<summary>* Focus/view the parent sequence, popping out of the current sub sequence section.</summary>
	public static void FocusParentSequence() {}
	///<summary>* Get the current sub section hierarchy from the current sequence to the section associated with the focused sequence.</summary>
	public static TArray<UMovieSceneSubSection> GetSubSequenceHierarchy() { return default; }
	///<summary>* Close</summary>
	public static void CloseLevelSequence() {}
	///<summary>Play the current level sequence</summary>
	public static void Play() {}
	///<summary>Pause the current level sequence</summary>
	public static void Pause() {}
	///<summary>Set global playback position for the current level sequence in frames</summary>
	public static void SetCurrentTime(int NewFrame) {}
	///<summary>Get the current global playback position in frames</summary>
	public static int GetCurrentTime() { return default; }
	///<summary>Set local playback position for the current level sequence in frames</summary>
	public static void SetCurrentLocalTime(int NewFrame) {}
	///<summary>Get the current local playback position in frames</summary>
	public static int GetCurrentLocalTime() { return default; }
	///<summary>Play from the current time to the requested time in frames</summary>
	public static void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams) {}
	///<summary>Check whether the sequence is actively playing.</summary>
	public static bool IsPlaying() { return default; }
	///<summary>Gets the currently selected tracks.</summary>
	public static TArray<UMovieSceneTrack> GetSelectedTracks() { return default; }
	///<summary>Gets the currently selected sections.</summary>
	public static TArray<UMovieSceneSection> GetSelectedSections() { return default; }
	///<summary>Gets the currently selected channels.</summary>
	public static TArray<FSequencerChannelProxy> GetSelectedChannels() { return default; }
	///<summary>Gets the currently selected folders.</summary>
	public static TArray<UMovieSceneFolder> GetSelectedFolders() { return default; }
	///<summary>GetSelectedObjects</summary>
	public static TArray<FGuid> GetSelectedObjects() { return default; }
	///<summary>Gets the currently selected object bindings</summary>
	public static TArray<FMovieSceneBindingProxy> GetSelectedBindings() { return default; }
	///<summary>Select tracks</summary>
	public static void SelectTracks(TArray<UMovieSceneTrack> Tracks) {}
	///<summary>Select sections</summary>
	public static void SelectSections(TArray<UMovieSceneSection> Sections) {}
	///<summary>Select channels</summary>
	public static void SelectChannels(TArray<FSequencerChannelProxy> Channels) {}
	///<summary>Select folders</summary>
	public static void SelectFolders(TArray<UMovieSceneFolder> Folders) {}
	///<summary>SelectObjects</summary>
	public static void SelectObjects(TArray<FGuid> ObjectBinding) {}
	///<summary>Select bindings</summary>
	public static void SelectBindings(TArray<FMovieSceneBindingProxy> ObjectBindings) {}
	///<summary>Empties the current selection.</summary>
	public static void EmptySelection() {}
	///<summary>Set the selection range start frame.</summary>
	public static void SetSelectionRangeStart(int NewFrame) {}
	///<summary>Set the selection range end frame.</summary>
	public static void SetSelectionRangeEnd(int NewFrame) {}
	///<summary>Get the selection range start frame.</summary>
	public static int GetSelectionRangeStart() { return default; }
	///<summary>Get the selection range end frame.</summary>
	public static int GetSelectionRangeEnd() { return default; }
	///<summary>Refresh Sequencer UI.</summary>
	public static void RefreshCurrentLevelSequence() {}
	///<summary>Get the object bound to the given binding ID with the current level sequence editor</summary>
	public static TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	///<summary>Check whether the current level sequence and its descendants are locked for editing.</summary>
	public static bool IsLevelSequenceLocked() { return default; }
	///<summary>Sets the lock for the current level sequence and its descendants for editing.</summary>
	public static void SetLockLevelSequence(bool bLock) {}
	///<summary>Check whether the lock for the viewport to the camera cuts is enabled.</summary>
	public static bool IsCameraCutLockedToViewport() { return default; }
	///<summary>Sets the lock for the viewport to the camera cuts.</summary>
	public static void SetLockCameraCutToViewport(bool bLock) {}
	///<summary>Gets whether the specified track filter is on/off</summary>
	public static bool IsTrackFilterEnabled(FText TrackFilterName) { return default; }
	///<summary>Sets the specified track filter to be on or off</summary>
	public static void SetTrackFilterEnabled(FText TrackFilterName,bool bEnabled) {}
	///<summary>Gets all the available track filter names</summary>
	public static TArray<FText> GetTrackFilterNames() { return default; }
	///<summary>Get if a custom color for specified channel idendified by it&#39;s class and identifier exists</summary>
	public static bool HasCustomColorForChannel(UClass Class,string Identifier) { return default; }
	///<summary>Get custom color for specified channel idendified by it&#39;s class and identifier,if none exists will return white</summary>
	public static FLinearColor GetCustomColorForChannel(UClass Class,string Identifier) { return default; }
	///<summary>Set Custom Color for specified channel idendified by it&#39;s class and identifier. This will be stored in editor user preferences.</summary>
	public static void SetCustomColorForChannel(UClass Class,string Identifier,FLinearColor NewColor) {}
	///<summary>Set Custom Color for specified channels idendified by it&#39;s class and identifiers. This will be stored in editor user preferences.</summary>
	public static void SetCustomColorForChannels(UClass Class,TArray<string> Identifiers,TArray<FLinearColor> NewColors) {}
	///<summary>Set Random Colors for specified channels idendified by it&#39;s class and identifiers. This will be stored in editor user preferences.</summary>
	public static void SetRandomColorForChannels(UClass Class,TArray<string> Identifiers) {}
	///<summary>Delete for specified channel idendified by it&#39;s class and identifier.</summary>
	public static void DeleteColorForChannels(UClass Class,string Identifier) {}
}
