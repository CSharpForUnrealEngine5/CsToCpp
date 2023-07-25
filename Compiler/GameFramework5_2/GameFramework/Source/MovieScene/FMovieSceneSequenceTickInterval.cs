#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneSequenceTickInterval.h")]
///<summary>Structure defining a concrete tick interval for a Sequencer based evaluation</summary>
public partial struct FMovieSceneSequenceTickInterval {
// MovieSceneSequenceTickInterval
	public float TickIntervalSeconds;
	public float EvaluationBudgetMicroseconds;
	public bool bTickWhenPaused;
	public bool bAllowRounding;
}
