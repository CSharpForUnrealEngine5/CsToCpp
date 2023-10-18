namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The configurable settings for a ULearningAgentsTrainer.</summary>
[CppInclude("LearningAgentsTrainer.h")]
public partial struct FLearningAgentsTrainerSettings {
	public ELearningAgentsCompletion MaxStepsCompletion;
	public int MaxStepNum;
	public int MaximumRecordedEpisodesPerIteration;
	public int MaximumRecordedStepsPerIteration;
	public float TrainerCommunicationTimeout;
}
