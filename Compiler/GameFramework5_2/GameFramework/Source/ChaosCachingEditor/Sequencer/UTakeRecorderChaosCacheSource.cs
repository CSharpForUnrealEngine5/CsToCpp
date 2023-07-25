#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/TakeRecorderChaosCacheSource.h")]
///<summary>A recording source selector for the chaos integration into take recorder</summary>
public partial class UTakeRecorderChaosCacheSource : UTakeRecorderSource {
// TakeRecorderChaosCacheSource
	public TSoftObjectPtr<AChaosCacheManager> ChaosCacheManager;
	public UMovieSceneChaosCacheTrackRecorder TrackRecorder;
}
