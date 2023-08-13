namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluation track that is stored within an evaluation template for a sequence.</summary>
[CppInclude("Evaluation/MovieSceneEvaluationTrack.h")]
public partial struct FMovieSceneEvaluationTrack {
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
