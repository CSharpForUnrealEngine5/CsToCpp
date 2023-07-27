#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/GameplayTask_TimeLimitedExecution.h")]
///<summary>Adds time limit for running a child task</summary>
public partial class UGameplayTask_TimeLimitedExecution : UGameplayTask {
// GameplayTask_TimeLimitedExecution
	public  void FTaskFinishDelegate() {}
	public FTaskFinishDelegate OnFinished;
	public FTaskFinishDelegate OnTimeExpired;
}
