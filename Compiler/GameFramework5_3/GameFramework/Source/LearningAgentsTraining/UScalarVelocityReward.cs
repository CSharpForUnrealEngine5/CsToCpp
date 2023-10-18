namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A reward for maximizing speed.</summary>
[CppInclude("LearningAgentsRewards.h")]
public partial class UScalarVelocityReward : ULearningAgentsReward {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new scalar velocity reward to the given trainer. Call during ULearningAgentsTrainer::SetupRewards event.</summary>
	public static UScalarVelocityReward AddScalarVelocityReward(ULearningAgentsTrainer InAgentTrainer,FName Name/*=NAME_None*/,float Weight/*=1.0f*/,float Scale/*=200.0f*/) { return default; }
	///<summary>Sets the data for this reward. Call during ULearningAgentsTrainer::SetRewards event.</summary>
	public void SetScalarVelocityReward(int AgentId,float Velocity) {}
}
