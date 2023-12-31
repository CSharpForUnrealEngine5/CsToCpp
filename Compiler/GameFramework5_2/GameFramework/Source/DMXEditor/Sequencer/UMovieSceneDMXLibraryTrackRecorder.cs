namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Track recorder implementation for DMX libraries</summary>
[CppInclude("Sequencer/MovieSceneDMXLibraryTrackRecorder.h")]
public partial class UMovieSceneDMXLibraryTrackRecorder : UMovieSceneTrackRecorder {
	public static UClass StaticClass() {return default;}
	///<summary>FixturePatchRefs</summary>
	public TArray<FDMXEntityFixturePatchRef> FixturePatchRefs;
}
