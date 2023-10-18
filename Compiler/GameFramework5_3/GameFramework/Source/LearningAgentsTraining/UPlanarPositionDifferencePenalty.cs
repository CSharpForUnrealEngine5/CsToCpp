namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A penalty for being far from a goal position in a plane.</summary>
[CppInclude("LearningAgentsRewards.h")]
public partial class UPlanarPositionDifferencePenalty : ULearningAgentsReward {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new planar difference penalty to the given trainer. The axis parameters define the plane.</summary>
	public static UPlanarPositionDifferencePenalty AddPlanarPositionDifferencePenalty(ULearningAgentsTrainer InAgentTrainer,FName Name/*=NAME_None*/,float Weight/*=1.0f*/,float Scale/*=100.0f*/,float Threshold/*=0.0f*/,FVector Axis0/*=FVector.ForwardVector*/,FVector Axis1/*=FVector.RightVector*/) { return default; }
	///<summary>Sets the data for this penalty. Call during ULearningAgentsTrainer::SetRewards event.</summary>
	public void SetPlanarPositionDifferencePenalty(int AgentId,FVector Position0,FVector Position1) {}
}
