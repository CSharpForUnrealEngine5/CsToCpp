#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
