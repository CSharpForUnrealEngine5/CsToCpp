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
