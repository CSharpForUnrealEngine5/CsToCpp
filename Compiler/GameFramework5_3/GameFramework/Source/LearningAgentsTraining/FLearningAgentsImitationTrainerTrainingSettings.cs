namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The configurable settings for the training process.</summary>
[CppInclude("LearningAgentsImitationTrainer.h")]
public partial struct FLearningAgentsImitationTrainerTrainingSettings {
	public int NumberOfIterations;
	public float LearningRate;
	public float LearningRateDecay;
	public float WeightDecay;
	public uint BatchSize;
	public int RandomSeed;
	public ELearningAgentsTrainerDevice Device;
	public bool bUseTensorboard;
}
