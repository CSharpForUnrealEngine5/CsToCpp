#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvalTemplate.h")]
///<summary>Structure used for movie scene evaluation templates contained within a track. Typically these are defined as one per-section.</summary>
public partial struct FMovieSceneEvalTemplate {
// MovieSceneEvalTemplate
	public EMovieSceneCompletionMode CompletionMode;
	public TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr;
}
