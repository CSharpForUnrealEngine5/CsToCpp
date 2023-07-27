#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/GameplayTask_WaitDelay.h")]
public partial class UGameplayTask_WaitDelay : UGameplayTask {
// GameplayTask_WaitDelay
	public  void FTaskDelayDelegate() {}
	public FTaskDelayDelegate OnFinish;
	public static UGameplayTask_WaitDelay TaskWaitDelay(object /*TaskOwner*/ TaskOwner,float Time,byte Priority/*=192*/) { return default; }
}
