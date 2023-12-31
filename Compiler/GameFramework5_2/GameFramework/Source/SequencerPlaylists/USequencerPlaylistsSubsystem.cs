namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerPlaylistsSubsystem.h")]
public partial class USequencerPlaylistsSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>EditorPackages</summary>
	public TMap<FSequencerPlaylistEditorHandle,UPackage> EditorPackages;
	///<summary>EditorPlayers</summary>
	public TMap<FSequencerPlaylistEditorHandle,USequencerPlaylistPlayer> EditorPlayers;
	///<summary>EditorPlaylists</summary>
	public TMap<FSequencerPlaylistEditorHandle,USequencerPlaylist> EditorPlaylists;
}
