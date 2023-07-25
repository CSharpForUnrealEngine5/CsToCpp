#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask.h")]
public partial class UGameplayTask : UObject {
// GameplayTask
	public void FGenericGameplayTaskDelegate() {}
	public void ReadyForActivation() {}
	public void EndTask() {}
	public string InstanceName;
	public ETaskResourceOverlapPolicy ResourceOverlapPolicy;
	public UGameplayTask ChildTask;
}
