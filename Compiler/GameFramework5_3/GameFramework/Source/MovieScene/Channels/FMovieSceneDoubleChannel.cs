namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneDoubleChannel.h")]
public partial struct FMovieSceneDoubleChannel {
	public ERichCurveExtrapolation PreInfinityExtrap;
	public ERichCurveExtrapolation PostInfinityExtrap;
	public TArray<FFrameNumber> Times;
	public TArray<FMovieSceneDoubleValue> Values;
	public double DefaultValue;
	public bool bHasDefaultValue;
	public FMovieSceneKeyHandleMap KeyHandles;
	public FFrameRate TickResolution;
	public bool bShowCurve;
}
