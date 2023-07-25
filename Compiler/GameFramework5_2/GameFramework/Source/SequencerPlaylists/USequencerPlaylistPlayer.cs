#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerPlaylistPlayer.h")]
///<summary>Controls playback of playlist items</summary>
public partial class USequencerPlaylistPlayer : UObject {
// SequencerPlaylistPlayer
	public void SetPlaylist(UObject InPlaylist) {}
	public UObject GetPlaylist() { return default; }
	public UObject GetDefaultPlayer() { return default; }
	public FOnPlayerSequencerPlaylistSet OnPlaylistSet;
	public bool PlayItem(UObject Item,ESequencerPlaylistPlaybackDirection Direction/*=ESequencerPlaylistPlaybackDirection.Forward*/) { return default; }
	public bool PauseItem(UObject Item) { return default; }
	public bool StopItem(UObject Item) { return default; }
	public bool ResetItem(UObject Item) { return default; }
	public bool IsPlaying(UObject Item) { return default; }
	public FSequencerPlaylistPlaybackState GetPlaybackState(UObject Item) { return default; }
	public bool PlayAll(ESequencerPlaylistPlaybackDirection Direction/*=ESequencerPlaylistPlaybackDirection.Forward*/) { return default; }
	public bool PauseAll() { return default; }
	public bool StopAll() { return default; }
	public bool ResetAll() { return default; }
	public USequencerPlaylist Playlist;
}
