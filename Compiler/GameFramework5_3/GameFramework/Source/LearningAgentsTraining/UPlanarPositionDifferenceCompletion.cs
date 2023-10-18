namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A completion for if two positions differ by some threshold in a plane, e.g. if the agent gets too far from a</summary>
[CppInclude("LearningAgentsCompletions.h")]
public partial class UPlanarPositionDifferenceCompletion : ULearningAgentsCompletion {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new planar position difference completion to the given trainer. The axis parameters define the plane.</summary>
	public static UPlanarPositionDifferenceCompletion AddPlanarPositionDifferenceCompletion(ULearningAgentsTrainer InAgentTrainer,FName Name/*=NAME_None*/,float Threshold/*=100.0f*/,ELearningAgentsCompletion InCompletionMode/*=ELearningAgentsCompletion.Termination*/,FVector Axis0/*=FVector.ForwardVector*/,FVector Axis1/*=FVector.RightVector*/) { return default; }
	///<summary>Sets the data for this completion. Call during ULearningAgentsTrainer::SetCompletions event.</summary>
	public void SetPlanarPositionDifferenceCompletion(int AgentId,FVector Position0,FVector Position1) {}
}
