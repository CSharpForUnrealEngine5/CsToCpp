#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A curve of events</summary>
[CppInclude("Sections/MovieSceneEventSection.h")]
public partial struct FMovieSceneEventSectionData {
	public TArray<FFrameNumber> Times;
	public TArray<FEventPayload> KeyValues;
	public FMovieSceneKeyHandleMap KeyHandles;
	public TArray<float> KeyTimes_DEPRECATED;
}
