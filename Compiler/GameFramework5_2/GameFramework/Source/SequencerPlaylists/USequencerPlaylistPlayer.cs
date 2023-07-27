#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerPlaylistPlayer.h")]
///<summary>Controls playback of playlist items</summary>
public partial class USequencerPlaylistPlayer : UObject {
// SequencerPlaylistPlayer
	public  void SetPlaylist(USequencerPlaylist InPlaylist) {}
	public  USequencerPlaylist GetPlaylist() { return default; }
	public static USequencerPlaylistPlayer GetDefaultPlayer() { return default; }
	public FOnPlayerSequencerPlaylistSet OnPlaylistSet;
	public  bool PlayItem(USequencerPlaylistItem Item,ESequencerPlaylistPlaybackDirection Direction/*=ESequencerPlaylistPlaybackDirection.Forward*/) { return default; }
	public  bool PauseItem(USequencerPlaylistItem Item) { return default; }
	public  bool StopItem(USequencerPlaylistItem Item) { return default; }
	public  bool ResetItem(USequencerPlaylistItem Item) { return default; }
	public  bool IsPlaying(USequencerPlaylistItem Item) { return default; }
	public  FSequencerPlaylistPlaybackState GetPlaybackState(USequencerPlaylistItem Item) { return default; }
	public  bool PlayAll(ESequencerPlaylistPlaybackDirection Direction/*=ESequencerPlaylistPlaybackDirection.Forward*/) { return default; }
	public  bool PauseAll() { return default; }
	public  bool StopAll() { return default; }
	public  bool ResetAll() { return default; }
	public USequencerPlaylist Playlist;
}
