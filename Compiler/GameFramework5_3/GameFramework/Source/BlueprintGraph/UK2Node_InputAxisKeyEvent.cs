namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_InputAxisKeyEvent.h")]
public partial class UK2Node_InputAxisKeyEvent : UK2Node_Event {
	public static UClass StaticClass() {return default;}
	///<summary>AxisKey</summary>
	public FKey AxisKey;
	///<summary>Prevents actors with lower priority from handling this input</summary>
	public bool bConsumeInput;
	///<summary>Should the binding execute even when the game is paused</summary>
	public bool bExecuteWhenPaused;
	///<summary>Should any bindings to this event in parent classes be removed</summary>
	public bool bOverrideParentBinding;
}
