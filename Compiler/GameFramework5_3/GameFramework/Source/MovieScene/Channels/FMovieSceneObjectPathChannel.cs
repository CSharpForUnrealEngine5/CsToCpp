namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneObjectPathChannel.h")]
public partial struct FMovieSceneObjectPathChannel {
	public UClass PropertyClass;
	public TArray<FFrameNumber> Times;
	public TArray<FMovieSceneObjectPathChannelKeyValue> Values;
	public FMovieSceneObjectPathChannelKeyValue DefaultValue;
	public FMovieSceneKeyHandleMap KeyHandles;
}
