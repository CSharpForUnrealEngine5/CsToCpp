#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_InputAction.h")]
public partial class UK2Node_InputAction : UK2Node {
	///<summary>InputActionName</summary>
	public string InputActionName;
	///<summary>Prevents actors with lower priority from handling this input</summary>
	public bool bConsumeInput;
	///<summary>Should the binding execute even when the game is paused</summary>
	public bool bExecuteWhenPaused;
	///<summary>Should any bindings to this event in parent classes be removed</summary>
	public bool bOverrideParentBinding;
}
