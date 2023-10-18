namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for a track in a Movie Scene</summary>
[CppInclude("MovieSceneTrack.h")]
public partial class UMovieSceneTrack : UMovieSceneSignedObject {
	public static UClass StaticClass() {return default;}
	///<summary>General evaluation options for a given track</summary>
	public FMovieSceneTrackEvalOptions EvalOptions;
	///<summary>General display options for a given track</summary>
	public FMovieSceneTrackDisplayOptions DisplayOptions;
	///<summary>Whether evaluation of this track has been disabled via mute/solo</summary>
	public bool bIsEvalDisabled;
	///<summary>Which rows have been disabled via mute/solo</summary>
	public TArray<int> RowsDisabled;
	///<summary>The guid of the object signature that the EvaluationField member relates to</summary>
	public FGuid EvaluationFieldGuid;
	///<summary>The version of the logic in PopulateEvaluationTree when the EvaluationField was cached</summary>
	public short EvaluationFieldVersion;
	///<summary>An array of entries that define when specific sections should be evaluated on this track</summary>
	public FMovieSceneTrackEvaluationField EvaluationField;
	///<summary>The object binding that this track resides within</summary>
	public FGuid ObjectBindingID;
	///<summary>This track&#39;s tint color</summary>
	public FColor TrackTint;
	///<summary>This folder&#39;s desired sorting order</summary>
	public int SortingOrder;
	///<summary>Does this track support the creation of a default section when created?</summary>
	public bool bSupportsDefaultSections;
}
