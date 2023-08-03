#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Controls playback of playlist items</summary>
[CppInclude("SequencerPlaylistPlayer.h")]
public partial class USequencerPlaylistPlayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SetPlaylist</summary>
	public  void SetPlaylist(USequencerPlaylist InPlaylist) {}
	///<summary>GetPlaylist</summary>
	public  USequencerPlaylist GetPlaylist() { return default; }
	///<summary>GetDefaultPlayer</summary>
	public static USequencerPlaylistPlayer GetDefaultPlayer() { return default; }
	///<summary>OnPlaylistSet</summary>
	public FOnPlayerSequencerPlaylistSet OnPlaylistSet;
	///<summary>PlayItem</summary>
	public  bool PlayItem(USequencerPlaylistItem Item,ESequencerPlaylistPlaybackDirection Direction/*=ESequencerPlaylistPlaybackDirection.Forward*/) { return default; }
	///<summary>PauseItem</summary>
	public  bool PauseItem(USequencerPlaylistItem Item) { return default; }
	///<summary>StopItem</summary>
	public  bool StopItem(USequencerPlaylistItem Item) { return default; }
	///<summary>ResetItem</summary>
	public  bool ResetItem(USequencerPlaylistItem Item) { return default; }
	///<summary>IsPlaying</summary>
	public  bool IsPlaying(USequencerPlaylistItem Item) { return default; }
	///<summary>GetPlaybackState</summary>
	public  FSequencerPlaylistPlaybackState GetPlaybackState(USequencerPlaylistItem Item) { return default; }
	///<summary>PlayAll</summary>
	public  bool PlayAll(ESequencerPlaylistPlaybackDirection Direction/*=ESequencerPlaylistPlaybackDirection.Forward*/) { return default; }
	///<summary>PauseAll</summary>
	public  bool PauseAll() { return default; }
	///<summary>StopAll</summary>
	public  bool StopAll() { return default; }
	///<summary>ResetAll</summary>
	public  bool ResetAll() { return default; }
	///<summary>Playlist</summary>
	public USequencerPlaylist Playlist;
}
