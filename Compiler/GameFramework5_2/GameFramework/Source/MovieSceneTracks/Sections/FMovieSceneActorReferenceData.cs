#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneActorReferenceSection.h")]
///<summary>A curve of events</summary>
public partial struct FMovieSceneActorReferenceData {
// MovieSceneActorReferenceData
	public TArray<FFrameNumber> KeyTimes;
	public FMovieSceneActorReferenceKey DefaultValue;
	public TArray<FMovieSceneActorReferenceKey> KeyValues;
	public FMovieSceneKeyHandleMap KeyHandles;
}
