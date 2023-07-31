#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds time limit for running a child task</summary>
[CppInclude("Tasks/GameplayTask_TimeLimitedExecution.h")]
public partial class UGameplayTask_TimeLimitedExecution : UGameplayTask {
	///<summary>FTaskFinishDelegate</summary>
	public  void FTaskFinishDelegate() {}
	///<summary>called when child task finishes execution before time runs out</summary>
	public FTaskFinishDelegate OnFinished;
	///<summary>called when time runs out</summary>
	public FTaskFinishDelegate OnTimeExpired;
}
