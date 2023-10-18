namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all rewards/penalties. Rewards are used during reinforcement learning to encourage/discourage</summary>
[CppInclude("LearningAgentsRewards.h")]
public partial class ULearningAgentsReward : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the Trainer this reward is associated with.</summary>
	public ULearningAgentsTrainer AgentTrainer;
}
