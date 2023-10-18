namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneBoolChannel.h")]
public partial struct FMovieSceneBoolChannel {
	public TArray<FFrameNumber> Times;
	public bool DefaultValue;
	public bool bHasDefaultValue;
	public TArray<bool> Values;
	public FMovieSceneKeyHandleMap KeyHandles;
}
