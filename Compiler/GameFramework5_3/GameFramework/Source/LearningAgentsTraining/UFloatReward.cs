namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple float reward. Used as a catch-all for situations where a more type-specific reward does not exist yet.</summary>
[CppInclude("LearningAgentsRewards.h")]
public partial class UFloatReward : ULearningAgentsReward {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new float reward to the given trainer. Call during ULearningAgentsTrainer::SetupRewards event.</summary>
	public static UFloatReward AddFloatReward(ULearningAgentsTrainer InAgentTrainer,FName Name/*=NAME_None*/,float Weight/*=1.0f*/) { return default; }
	///<summary>Sets the data for this reward. Call during ULearningAgentsTrainer::SetRewards event.</summary>
	public void SetFloatReward(int AgentId,float Reward) {}
}
