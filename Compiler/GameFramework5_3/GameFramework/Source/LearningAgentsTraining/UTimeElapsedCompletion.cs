namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A completion for if a given amount of time has elapsed.</summary>
[CppInclude("LearningAgentsCompletions.h")]
public partial class UTimeElapsedCompletion : ULearningAgentsCompletion {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new time elapsed completion to the given trainer. Call during ULearningAgentsTrainer::SetupCompletions event.</summary>
	public static UTimeElapsedCompletion AddTimeElapsedCompletion(ULearningAgentsTrainer InAgentTrainer,FName Name/*=NAME_None*/,float Threshold/*=10.0f*/,ELearningAgentsCompletion InCompletionMode/*=ELearningAgentsCompletion.Termination*/) { return default; }
	///<summary>Sets the data for this completion. Call during ULearningAgentsTrainer::SetCompletions event.</summary>
	public void SetTimeElapsedCompletion(int AgentId,float Time) {}
}
