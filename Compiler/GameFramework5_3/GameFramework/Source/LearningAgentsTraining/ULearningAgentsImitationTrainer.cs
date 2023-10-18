namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The ULearningAgentsImitationTrainer enable imitation learning, i.e. learning from human/AI demonstrations.</summary>
[CppInclude("LearningAgentsImitationTrainer.h")]
public partial class ULearningAgentsImitationTrainer : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if the trainer is currently training; Otherwise, false.</summary>
	public bool IsTraining() { return default; }
	///<summary>Returns true if the trainer has failed to communicate with the external training process. This can be used in</summary>
	public bool HasTrainingFailed() { return default; }
	///<summary>Begins the training process with the provided settings.</summary>
	public void BeginTraining(ULearningAgentsPolicy InPolicy,ULearningAgentsRecording Recording,FLearningAgentsImitationTrainerSettings ImitationTrainerSettings/*=new FLearningAgentsImitationTrainerSettings()*/,FLearningAgentsImitationTrainerTrainingSettings ImitationTrainerTrainingSettings/*=new FLearningAgentsImitationTrainerTrainingSettings()*/,FLearningAgentsTrainerPathSettings ImitationTrainerPathSettings/*=new FLearningAgentsTrainerPathSettings()*/,bool bReinitializePolicyNetwork/*=true*/) {}
	///<summary>Stops the training process.</summary>
	public void EndTraining() {}
	///<summary>Iterates the training process and gets the updated policy network.</summary>
	public void IterateTraining() {}
	///<summary>Convenience function that runs a basic training loop. If training has not been started, it will start it. On</summary>
	public void RunTraining(ULearningAgentsPolicy InPolicy,ULearningAgentsRecording Recording,FLearningAgentsImitationTrainerSettings ImitationTrainerSettings/*=new FLearningAgentsImitationTrainerSettings()*/,FLearningAgentsImitationTrainerTrainingSettings ImitationTrainerTrainingSettings/*=new FLearningAgentsImitationTrainerTrainingSettings()*/,FLearningAgentsTrainerPathSettings ImitationTrainerPathSettings/*=new FLearningAgentsTrainerPathSettings()*/,bool bReinitializePolicyNetwork/*=true*/) {}
	///<summary>The policy being trained.</summary>
	public ULearningAgentsPolicy Policy;
	///<summary>True if training is currently in-progress. Otherwise, false.</summary>
	public bool bIsTraining;
	///<summary>True if trainer encountered an unrecoverable error during training (e.g. the trainer process timed out). Otherwise, false.</summary>
	public bool bHasTrainingFailed;
}
