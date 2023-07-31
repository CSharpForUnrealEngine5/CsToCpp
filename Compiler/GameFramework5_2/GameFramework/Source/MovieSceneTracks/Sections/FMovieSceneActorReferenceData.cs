#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A curve of events</summary>
[CppInclude("Sections/MovieSceneActorReferenceSection.h")]
public partial struct FMovieSceneActorReferenceData {
	public TArray<FFrameNumber> KeyTimes;
	public FMovieSceneActorReferenceKey DefaultValue;
	public TArray<FMovieSceneActorReferenceKey> KeyValues;
	public FMovieSceneKeyHandleMap KeyHandles;
}
