namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_InputTouch.h")]
public partial class UK2Node_InputTouch : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>Prevents actors with lower priority from handling this input</summary>
	public bool bConsumeInput;
	///<summary>Should the binding execute even when the game is paused</summary>
	public bool bExecuteWhenPaused;
	///<summary>Should any bindings to this event in parent classes be removed</summary>
	public bool bOverrideParentBinding;
}
