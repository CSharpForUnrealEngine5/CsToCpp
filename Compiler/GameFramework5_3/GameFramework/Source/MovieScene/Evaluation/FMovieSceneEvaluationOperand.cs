namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that describes an object that is to be animated. Used as an abstraction of the actual objects bound to object bindings.</summary>
[CppInclude("Evaluation/MovieSceneEvaluationOperand.h")]
public partial struct FMovieSceneEvaluationOperand {
	public FGuid ObjectBindingID;
	public FMovieSceneSequenceID SequenceID;
}
