namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask.h")]
public partial class UGameplayTask : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FGenericGameplayTaskDelegate</summary>
	public void FGenericGameplayTaskDelegate() {}
	///<summary>Called to trigger the actual task once the delegates have been set up</summary>
	public void ReadyForActivation() {}
	///<summary>Called explicitly to end the task (usually by the task itself). Calls OnDestroy.</summary>
	public void EndTask() {}
	///<summary>This name allows us to find the task later so that we can end it.</summary>
	public FName InstanceName;
	///<summary>ResourceOverlapPolicy</summary>
	public ETaskResourceOverlapPolicy ResourceOverlapPolicy;
	///<summary>child task instance</summary>
	public UGameplayTask ChildTask;
}
