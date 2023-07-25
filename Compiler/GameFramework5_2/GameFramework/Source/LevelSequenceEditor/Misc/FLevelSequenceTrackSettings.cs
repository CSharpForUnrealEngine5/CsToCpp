#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Misc/LevelSequenceEditorSettings.h")]
public partial struct FLevelSequenceTrackSettings {
// LevelSequenceTrackSettings
	public FSoftClassPath MatchingActorClass;
	public TArray<FSoftClassPath> DefaultTracks;
	public TArray<FSoftClassPath> ExcludeDefaultTracks;
	public TArray<FLevelSequencePropertyTrackSettings> DefaultPropertyTracks;
	public TArray<FLevelSequencePropertyTrackSettings> ExcludeDefaultPropertyTracks;
}
