namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds time limit for running a child task</summary>
[CppInclude("Tasks/GameplayTask_TimeLimitedExecution.h")]
public partial class UGameplayTask_TimeLimitedExecution : UGameplayTask {
	public static UClass StaticClass() {return default;}
	///<summary>FTaskFinishDelegate</summary>
	public void FTaskFinishDelegate() {}
	///<summary>called when child task finishes execution before time runs out</summary>
	public FTaskFinishDelegate OnFinished;
	///<summary>called when time runs out</summary>
	public FTaskFinishDelegate OnTimeExpired;
}
