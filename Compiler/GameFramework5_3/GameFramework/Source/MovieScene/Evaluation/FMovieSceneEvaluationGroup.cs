namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds segment pointers for all segments that are active for a given range of the sequence</summary>
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
public partial struct FMovieSceneEvaluationGroup {
	public TArray<FMovieSceneEvaluationGroupLUTIndex> LUTIndices;
	public TArray<FMovieSceneFieldEntry_EvaluationTrack> TrackLUT;
	public TArray<FMovieSceneFieldEntry_ChildTemplate> SectionLUT;
}
