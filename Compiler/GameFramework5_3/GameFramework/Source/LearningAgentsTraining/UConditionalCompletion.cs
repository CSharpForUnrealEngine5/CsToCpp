namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple boolean completion. Used as a catch-all for situations where a more type-specific completion does not exist yet.</summary>
[CppInclude("LearningAgentsCompletions.h")]
public partial class UConditionalCompletion : ULearningAgentsCompletion {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new conditional completion to the given trainer. Call during ULearningAgentsTrainer::SetupCompletions event.</summary>
	public static UConditionalCompletion AddConditionalCompletion(ULearningAgentsTrainer InAgentTrainer,FName Name/*=NAME_None*/,ELearningAgentsCompletion InCompletionMode/*=ELearningAgentsCompletion.Termination*/) { return default; }
	///<summary>Sets the data for this completion. Call during ULearningAgentsTrainer::SetCompletions event.</summary>
	public void SetConditionalCompletion(int AgentId,bool bIsCompleted) {}
}
