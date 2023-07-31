#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_GetInputAxisValue.h")]
public partial class UK2Node_GetInputAxisValue : UK2Node_CallFunction {
	///<summary>InputAxisName</summary>
	public string InputAxisName;
	///<summary>Prevents actors with lower priority from handling this input</summary>
	public bool bConsumeInput;
	///<summary>Should the binding gather input even when the game is paused</summary>
	public bool bExecuteWhenPaused;
}
