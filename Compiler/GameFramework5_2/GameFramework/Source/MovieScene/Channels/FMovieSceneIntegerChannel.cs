#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneIntegerChannel.h")]
public partial struct FMovieSceneIntegerChannel {
	public TArray<FFrameNumber> Times;
	public int DefaultValue;
	public bool bHasDefaultValue;
	public TArray<int> Values;
	public FMovieSceneKeyHandleMap KeyHandles;
}
