namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneTextChannel.h")]
public partial struct FMovieSceneTextChannel {
	public TArray<FFrameNumber> Times;
	public TArray<FText> Values;
	public FText DefaultValue;
	public bool bHasDefaultValue;
	public FMovieSceneKeyHandleMap KeyHandles;
}
