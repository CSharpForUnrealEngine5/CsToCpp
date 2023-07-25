#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationTrack.h")]
///<summary>Evaluation track that is stored within an evaluation template for a sequence.</summary>
public partial struct FMovieSceneEvaluationTrack {
// MovieSceneEvaluationTrack
	public FGuid ObjectBindingID;
	public ushort EvaluationPriority;
	public EEvaluationMethod EvaluationMethod;
	public TWeakObjectPtr<UMovieSceneTrack> SourceTrack;
	public TArray<FMovieSceneEvalTemplatePtr> ChildTemplates;
	public FMovieSceneTrackImplementationPtr TrackTemplate;
	public string EvaluationGroup;
	public bool bEvaluateInPreroll;
	public bool bEvaluateInPostroll;
	public bool bTearDownPriority;
}
