#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TrackRecorders/IMovieSceneTrackRecorderHost.h")]
public partial struct FTakeRecorderTrackSettings {
// TakeRecorderTrackSettings
	public FSoftClassPath MatchingActorClass;
	public TArray<FTakeRecorderPropertyTrackSettings> DefaultPropertyTracks;
	public TArray<FTakeRecorderPropertyTrackSettings> ExcludePropertyTracks;
}
