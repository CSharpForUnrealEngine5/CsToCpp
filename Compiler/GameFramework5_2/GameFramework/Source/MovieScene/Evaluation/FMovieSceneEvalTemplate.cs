namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure used for movie scene evaluation templates contained within a track. Typically these are defined as one per-section.</summary>
[CppInclude("Evaluation/MovieSceneEvalTemplate.h")]
public partial struct FMovieSceneEvalTemplate {
	public EMovieSceneCompletionMode CompletionMode;
	public TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr;
}
