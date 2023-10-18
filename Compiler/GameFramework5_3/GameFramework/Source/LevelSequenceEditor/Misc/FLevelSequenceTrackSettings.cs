namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Misc/LevelSequenceEditorSettings.h")]
public partial struct FLevelSequenceTrackSettings {
	public FSoftClassPath MatchingActorClass;
	public TArray<FSoftClassPath> DefaultTracks;
	public TArray<FSoftClassPath> ExcludeDefaultTracks;
	public TArray<FLevelSequencePropertyTrackSettings> DefaultPropertyTracks;
	public TArray<FLevelSequencePropertyTrackSettings> ExcludeDefaultPropertyTracks;
}
