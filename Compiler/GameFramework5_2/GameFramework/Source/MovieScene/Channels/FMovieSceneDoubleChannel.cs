#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneDoubleChannel.h")]
public partial struct FMovieSceneDoubleChannel {
// MovieSceneDoubleChannel
	public byte PreInfinityExtrap;
	public byte PostInfinityExtrap;
	public TArray<FFrameNumber> Times;
	public TArray<FMovieSceneDoubleValue> Values;
	public double DefaultValue;
	public bool bHasDefaultValue;
	public FMovieSceneKeyHandleMap KeyHandles;
	public FFrameRate TickResolution;
	public bool bShowCurve;
}
