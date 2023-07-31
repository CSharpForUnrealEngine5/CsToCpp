#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
