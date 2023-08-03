#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/GameplayTask_WaitDelay.h")]
public partial class UGameplayTask_WaitDelay : UGameplayTask {
	public static UClass StaticClass() {return default;}
	///<summary>FTaskDelayDelegate</summary>
	public  void FTaskDelayDelegate() {}
	///<summary>OnFinish</summary>
	public FTaskDelayDelegate OnFinish;
	///<summary>Wait specified time. This is functionally the same as a standard Delay node.</summary>
	public static UGameplayTask_WaitDelay TaskWaitDelay(object /*TaskOwner*/ TaskOwner,float Time,byte Priority/*=192*/) { return default; }
}
