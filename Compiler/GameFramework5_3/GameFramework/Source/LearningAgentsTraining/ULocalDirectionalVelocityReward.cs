namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A reward for maximizing velocity along a given local axis.</summary>
[CppInclude("LearningAgentsRewards.h")]
public partial class ULocalDirectionalVelocityReward : ULearningAgentsReward {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new directional velocity reward to the given trainer. Call during ULearningAgentsTrainer::SetupRewards event.</summary>
	public static ULocalDirectionalVelocityReward AddLocalDirectionalVelocityReward(ULearningAgentsTrainer InAgentTrainer,FName Name/*=NAME_None*/,float Weight/*=1.0f*/,float Scale/*=200.0f*/,FVector Axis/*=FVector.ForwardVector*/) { return default; }
	///<summary>Sets the data for this reward. Call during ULearningAgentsTrainer::SetRewards event.</summary>
	public void SetLocalDirectionalVelocityReward(int AgentId,FVector Velocity,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
