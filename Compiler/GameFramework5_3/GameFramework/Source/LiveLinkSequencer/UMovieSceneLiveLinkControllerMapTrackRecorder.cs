namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie Scene track recorder for LiveLink Component&#39;s Controller Map</summary>
[CppInclude("MovieSceneLiveLinkControllerMapTrackRecorder.h")]
public partial class UMovieSceneLiveLinkControllerMapTrackRecorder : UMovieSceneTrackRecorder {
	public static UClass StaticClass() {return default;}
	///<summary>Array of track recorders that will record each of the LiveLink controller&#39;s in the Controller Map</summary>
	public TArray<UMovieSceneLiveLinkControllerTrackRecorder> ControllerRecorders;
}
