#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneObjectPathChannel.h")]
public partial struct FMovieSceneObjectPathChannel {
// MovieSceneObjectPathChannel
	public UClass PropertyClass;
	public TArray<FFrameNumber> Times;
	public TArray<FMovieSceneObjectPathChannelKeyValue> Values;
	public FMovieSceneObjectPathChannelKeyValue DefaultValue;
	public FMovieSceneKeyHandleMap KeyHandles;
}
