#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneEventChannel.h")]
public partial struct FMovieSceneEventChannel {
	public TArray<FFrameNumber> KeyTimes;
	public TArray<FMovieSceneEvent> KeyValues;
	public FMovieSceneKeyHandleMap KeyHandles;
}
