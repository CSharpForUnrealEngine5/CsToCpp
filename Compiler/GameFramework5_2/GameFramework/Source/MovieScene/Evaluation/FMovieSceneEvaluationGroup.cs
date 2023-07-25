#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
///<summary>Holds segment pointers for all segments that are active for a given range of the sequence</summary>
public partial struct FMovieSceneEvaluationGroup {
// MovieSceneEvaluationGroup
	public TArray<FMovieSceneEvaluationGroupLUTIndex> LUTIndices;
	public TArray<FMovieSceneFieldEntry_EvaluationTrack> TrackLUT;
	public TArray<FMovieSceneFieldEntry_ChildTemplate> SectionLUT;
}
