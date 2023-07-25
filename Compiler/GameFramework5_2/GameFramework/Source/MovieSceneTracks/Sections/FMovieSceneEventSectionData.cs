#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneEventSection.h")]
///<summary>A curve of events</summary>
public partial struct FMovieSceneEventSectionData {
// MovieSceneEventSectionData
	public TArray<FFrameNumber> Times;
	public TArray<FEventPayload> KeyValues;
	public FMovieSceneKeyHandleMap KeyHandles;
	public TArray<float> KeyTimes_DEPRECATED;
}
