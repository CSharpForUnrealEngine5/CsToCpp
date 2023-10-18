namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The configurable settings for the training process.</summary>
[CppInclude("LearningAgentsTrainer.h")]
public partial struct FLearningAgentsTrainerTrainingSettings {
	public int NumberOfIterations;
	public float LearningRatePolicy;
	public float LearningRateCritic;
	public float LearningRateDecay;
	public float WeightDecay;
	public float InitialActionScale;
	public int BatchSize;
	public float EpsilonClip;
	public float ActionRegularizationWeight;
	public float EntropyWeight;
	public float GaeLambda;
	public bool bClipAdvantages;
	public bool bAdvantageNormalization;
	public int NumberOfStepsToTrimAtStartOfEpisode;
	public int NumberOfStepsToTrimAtEndOfEpisode;
	public int RandomSeed;
	public float DiscountFactor;
	public ELearningAgentsTrainerDevice Device;
	public bool bUseTensorboard;
}
