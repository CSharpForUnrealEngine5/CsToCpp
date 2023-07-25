#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneTrack.h")]
///<summary>Base class for a track in a Movie Scene</summary>
public partial class UMovieSceneTrack : UMovieSceneSignedObject {
// MovieSceneTrack
	public FMovieSceneTrackEvalOptions EvalOptions;
	public FMovieSceneTrackDisplayOptions DisplayOptions;
	public bool bIsEvalDisabled;
	public TArray<int> RowsDisabled;
	public FGuid EvaluationFieldGuid;
	public short EvaluationFieldVersion;
	public FMovieSceneTrackEvaluationField EvaluationField;
	public FGuid ObjectBindingID;
	public FColor TrackTint;
	public int SortingOrder;
	public bool bSupportsDefaultSections;
}
