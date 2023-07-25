#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneTrackEvaluationField.h")]
public partial struct FMovieSceneTrackEvaluationFieldEntry {
// MovieSceneTrackEvaluationFieldEntry
	public UMovieSceneSection Section;
	public FFrameNumberRange Range;
	public FFrameNumber ForcedTime;
	public ESectionEvaluationFlags Flags;
	public short LegacySortOrder;
}
