#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TrackRecorders/IMovieSceneTrackRecorderHost.h")]
public partial struct FTakeRecorderTrackSettings {
	public FSoftClassPath MatchingActorClass;
	public TArray<FTakeRecorderPropertyTrackSettings> DefaultPropertyTracks;
	public TArray<FTakeRecorderPropertyTrackSettings> ExcludePropertyTracks;
}
