#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneFloatChannel.h")]
public partial struct FMovieSceneFloatChannel {
// MovieSceneFloatChannel
	public ERichCurveExtrapolation PreInfinityExtrap;
	public ERichCurveExtrapolation PostInfinityExtrap;
	public TArray<FFrameNumber> Times;
	public TArray<FMovieSceneFloatValue> Values;
	public float DefaultValue;
	public bool bHasDefaultValue;
	public FMovieSceneKeyHandleMap KeyHandles;
	public FFrameRate TickResolution;
	public bool bShowCurve;
}
