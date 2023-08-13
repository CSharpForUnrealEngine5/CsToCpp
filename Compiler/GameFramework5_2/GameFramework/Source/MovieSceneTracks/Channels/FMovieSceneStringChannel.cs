namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneStringChannel.h")]
public partial struct FMovieSceneStringChannel {
	public TArray<FFrameNumber> Times;
	public TArray<string> Values;
	public string DefaultValue;
	public bool bHasDefaultValue;
	public FMovieSceneKeyHandleMap KeyHandles;
}
