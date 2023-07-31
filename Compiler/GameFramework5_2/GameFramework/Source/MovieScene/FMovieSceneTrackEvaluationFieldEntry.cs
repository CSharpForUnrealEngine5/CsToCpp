#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneTrackEvaluationField.h")]
public partial struct FMovieSceneTrackEvaluationFieldEntry {
	public UMovieSceneSection Section;
	public FFrameNumberRange Range;
	public FFrameNumber ForcedTime;
	public ESectionEvaluationFlags Flags;
	public short LegacySortOrder;
}
