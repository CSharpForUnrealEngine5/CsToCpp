#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerPlaylistsSubsystem.h")]
public partial class USequencerPlaylistsSubsystem : UEditorSubsystem {
// SequencerPlaylistsSubsystem
	public TMap<FSequencerPlaylistEditorHandle,UPackage> EditorPackages;
	public TMap<FSequencerPlaylistEditorHandle,USequencerPlaylistPlayer> EditorPlayers;
	public TMap<FSequencerPlaylistEditorHandle,USequencerPlaylist> EditorPlaylists;
}
