#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityTask.h")]
public partial class UEditorUtilityTask : UObject {
	///<summary>Run</summary>
	public  void Run() {}
	///<summary>FinishExecutingTask</summary>
	public  void FinishExecutingTask() {}
	///<summary>SetTaskNotificationText</summary>
	public  void SetTaskNotificationText(string Text) {}
	///<summary>WasCancelRequested</summary>
	public  bool WasCancelRequested() { return default; }
	///<summary>ReceiveBeginExecution</summary>
	public  void ReceiveBeginExecution() {}
	///<summary>ReceiveCancelRequested</summary>
	public  void ReceiveCancelRequested() {}
	///<summary>MyTaskManager</summary>
	public UEditorUtilitySubsystem MyTaskManager;
	///<summary>MyParentTask</summary>
	public UEditorUtilityTask MyParentTask;
	///<summary>bCancelRequested</summary>
	public bool bCancelRequested;
}
