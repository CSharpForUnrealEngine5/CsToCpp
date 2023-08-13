namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure defining a concrete tick interval for a Sequencer based evaluation</summary>
[CppInclude("MovieSceneSequenceTickInterval.h")]
public partial struct FMovieSceneSequenceTickInterval {
	public float TickIntervalSeconds;
	public float EvaluationBudgetMicroseconds;
	public bool bTickWhenPaused;
	public bool bAllowRounding;
}
