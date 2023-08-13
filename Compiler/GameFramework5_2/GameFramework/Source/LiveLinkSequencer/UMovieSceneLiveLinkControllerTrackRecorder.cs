namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract based for movie scene track recorders that can record LiveLink Controllers</summary>
[CppInclude("MovieSceneLiveLinkControllerTrackRecorder.h")]
public partial class UMovieSceneLiveLinkControllerTrackRecorder : UMovieSceneTrackRecorder {
	public static UClass StaticClass() {return default;}
	///<summary>The LiveLink controller that this track record will record properties from</summary>
	public ULiveLinkControllerBase LiveLinkControllerToRecord;
}
