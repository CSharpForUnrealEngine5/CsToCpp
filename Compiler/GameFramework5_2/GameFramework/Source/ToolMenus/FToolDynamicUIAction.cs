#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuDelegates.h")]
public partial struct FToolDynamicUIAction {
// ToolDynamicUIAction
	public FToolMenuDynamicExecuteAction ExecuteAction;
	public FToolMenuDynamicCanExecuteAction CanExecuteAction;
	public FToolMenuDynamicGetActionCheckState GetActionCheckState;
	public FToolMenuDynamicIsActionButtonVisible IsActionVisibleDelegate;
}
