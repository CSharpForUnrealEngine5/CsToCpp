namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A reward for minimizing the distances of positions in the given arrays.</summary>
[CppInclude("LearningAgentsRewards.h")]
public partial class UPositionArraySimilarityReward : ULearningAgentsReward {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new position array similarity reward to the given trainer. Call during ULearningAgentsTrainer::SetupRewards event.</summary>
	public static UPositionArraySimilarityReward AddPositionArraySimilarityReward(ULearningAgentsTrainer InAgentTrainer,FName Name/*=NAME_None*/,int PositionNum/*=0*/,float Scale/*=100.0f*/,float Weight/*=1.0f*/) { return default; }
	///<summary>Sets the data for this reward. Call during ULearningAgentsTrainer::SetRewards event.</summary>
	public void SetPositionArraySimilarityReward(int AgentId,TArray<FVector> Positions0,TArray<FVector> Positions1,FVector RelativePosition0/*=FVector.ZeroVector*/,FVector RelativePosition1/*=FVector.ZeroVector*/,FRotator RelativeRotation0/*=FRotator.ZeroRotator*/,FRotator RelativeRotation1/*=FRotator.ZeroRotator*/) {}
}
