namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source selector for the chaos integration into take recorder</summary>
[CppInclude("Sequencer/TakeRecorderChaosCacheSource.h")]
public partial class UTakeRecorderChaosCacheSource : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>Chaos Cache manager to be used as take recorder source</summary>
	public TSoftObjectPtr<AChaosCacheManager> ChaosCacheManager;
	///<summary>Chaos cache track recorder used by this source</summary>
	public UMovieSceneChaosCacheTrackRecorder TrackRecorder;
}
