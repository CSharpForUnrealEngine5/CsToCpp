namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The ULearningAgentsTrainer is the core class for reinforcement learning training. It has a few responsibilities:</summary>
[CppInclude("LearningAgentsTrainer.h")]
public partial class ULearningAgentsTrainer : ULearningAgentsManagerComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Initializes this object and runs the setup functions for rewards and completions.</summary>
	public void SetupTrainer(ULearningAgentsInteractor InInteractor,ULearningAgentsPolicy InPolicy,ULearningAgentsCritic InCritic/*=nullptr*/,FLearningAgentsTrainerSettings TrainerSettings/*=new FLearningAgentsTrainerSettings()*/) {}
	///<summary>During this event, all rewards/penalties should be added to this trainer.</summary>
	public void SetupRewards() {}
	///<summary>During this event, all rewards/penalties should be set for each agent.</summary>
	public void SetRewards(TArray<int> AgentIds) {}
	///<summary>During this event, all completions should be added to this trainer.</summary>
	public void SetupCompletions() {}
	///<summary>During this event, all completions should be set for each agent.</summary>
	public void SetCompletions(TArray<int> AgentIds) {}
	///<summary>During this event, all episodes should be reset for each agent.</summary>
	public void ResetEpisodes(TArray<int> AgentIds) {}
	///<summary>Returns true if the trainer is currently training; Otherwise, false.</summary>
	public bool IsTraining() { return default; }
	///<summary>Begins the training process with the provided settings.</summary>
	public void BeginTraining(FLearningAgentsTrainerTrainingSettings TrainerTrainingSettings/*=new FLearningAgentsTrainerTrainingSettings()*/,FLearningAgentsTrainerGameSettings TrainerGameSettings/*=new FLearningAgentsTrainerGameSettings()*/,FLearningAgentsTrainerPathSettings TrainerPathSettings/*=new FLearningAgentsTrainerPathSettings()*/,FLearningAgentsCriticSettings CriticSettings/*=new FLearningAgentsCriticSettings()*/,bool bReinitializePolicyNetwork/*=true*/,bool bReinitializeCriticNetwork/*=true*/,bool bResetAgentsOnBegin/*=true*/) {}
	///<summary>Stops the training process.</summary>
	public void EndTraining() {}
	///<summary>Call this function when it is time to evaluate the rewards for your agents. This should be done at the beginning</summary>
	public void EvaluateRewards() {}
	///<summary>Call this function when it is time to evaluate the completions for your agents. This should be done at the beginning</summary>
	public void EvaluateCompletions() {}
	///<summary>Call this function at the end of each step of your training loop. This takes the current observations/actions/</summary>
	public void ProcessExperience() {}
	///<summary>Convenience function that runs a basic training loop. If training has not been started, it will start it, and</summary>
	public void RunTraining(FLearningAgentsTrainerTrainingSettings TrainerTrainingSettings/*=new FLearningAgentsTrainerTrainingSettings()*/,FLearningAgentsTrainerGameSettings TrainerGameSettings/*=new FLearningAgentsTrainerGameSettings()*/,FLearningAgentsTrainerPathSettings TrainerPathSettings/*=new FLearningAgentsTrainerPathSettings()*/,FLearningAgentsCriticSettings CriticSettings/*=new FLearningAgentsCriticSettings()*/,bool bReinitializePolicyNetwork/*=true*/,bool bReinitializeCriticNetwork/*=true*/,bool bResetAgentsOnBegin/*=true*/) {}
	///<summary>Gets the current reward for an agent according to the critic. Should be called only after EvaluateRewards.</summary>
	public float GetReward(int AgentId) { return default; }
	///<summary>Gets if the agent will complete the episode or not according to the given set of completions. Should be called</summary>
	public bool IsCompleted(int AgentId,ELearningAgentsCompletion OutCompletion) { return default; }
	///<summary>Returns true if the trainer has failed to communicate with the external training process. This can be used in</summary>
	public bool HasTrainingFailed() { return default; }
	///<summary>The agent interactor associated with this component.</summary>
	public ULearningAgentsInteractor Interactor;
	///<summary>The current policy for experience gathering.</summary>
	public ULearningAgentsPolicy Policy;
	///<summary>The current critic.</summary>
	public ULearningAgentsCritic Critic;
	///<summary>True if training is currently in-progress. Otherwise, false.</summary>
	public bool bIsTraining;
	///<summary>True if trainer encountered an unrecoverable error during training (e.g. the trainer process timed out). Otherwise, false.</summary>
	public bool bHasTrainingFailed;
	///<summary>The list of current reward objects.</summary>
	public TArray<ULearningAgentsReward> RewardObjects;
	///<summary>The list of current completion objects.</summary>
	public TArray<ULearningAgentsCompletion> CompletionObjects;
}
