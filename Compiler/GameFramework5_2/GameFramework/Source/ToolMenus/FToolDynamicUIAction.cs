namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuDelegates.h")]
public partial struct FToolDynamicUIAction {
	public FToolMenuDynamicExecuteAction ExecuteAction;
	public FToolMenuDynamicCanExecuteAction CanExecuteAction;
	public FToolMenuDynamicGetActionCheckState GetActionCheckState;
	public FToolMenuDynamicIsActionButtonVisible IsActionVisibleDelegate;
}
