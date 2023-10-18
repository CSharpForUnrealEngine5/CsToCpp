namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple conditional reward that gives some constant reward value when a condition is true.</summary>
[CppInclude("LearningAgentsRewards.h")]
public partial class UConditionalReward : ULearningAgentsReward {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new conditional reward to the given trainer. Call during ULearningAgentsTrainer::SetupRewards event.</summary>
	public static UConditionalReward AddConditionalReward(ULearningAgentsTrainer InAgentTrainer,FName Name/*=NAME_None*/,float Value/*=1.0f*/) { return default; }
	///<summary>Sets if the agent should receive a reward. Call during ULearningAgentsTrainer::SetRewards event.</summary>
	public void SetConditionalReward(int AgentId,bool bCondition) {}
}
