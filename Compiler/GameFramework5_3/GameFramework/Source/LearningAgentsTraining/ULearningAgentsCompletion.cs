namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class for all completions. Completions contain logic that determines if an agent&#39;s current episode should</summary>
[CppInclude("LearningAgentsCompletions.h")]
public partial class ULearningAgentsCompletion : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the Trainer this completion is associated with.</summary>
	public ULearningAgentsTrainer AgentTrainer;
}
