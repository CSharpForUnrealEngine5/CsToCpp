#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityTask.h")]
public partial class UEditorUtilityTask : UObject {
// EditorUtilityTask
	public  void Run() {}
	public  void FinishExecutingTask() {}
	public  void SetTaskNotificationText(string Text) {}
	public  bool WasCancelRequested() { return default; }
	public  void ReceiveBeginExecution() {}
	public  void ReceiveCancelRequested() {}
	public UEditorUtilitySubsystem MyTaskManager;
	public UEditorUtilityTask MyParentTask;
	public bool bCancelRequested;
}
