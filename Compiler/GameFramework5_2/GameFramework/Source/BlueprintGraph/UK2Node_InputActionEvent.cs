namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_InputActionEvent.h")]
public partial class UK2Node_InputActionEvent : UK2Node_Event {
	public static UClass StaticClass() {return default;}
	///<summary>InputActionName</summary>
	public string InputActionName;
	///<summary>InputKeyEvent</summary>
	public EInputEvent InputKeyEvent;
	///<summary>bConsumeInput</summary>
	public bool bConsumeInput;
	///<summary>bExecuteWhenPaused</summary>
	public bool bExecuteWhenPaused;
	///<summary>bOverrideParentBinding</summary>
	public bool bOverrideParentBinding;
}
