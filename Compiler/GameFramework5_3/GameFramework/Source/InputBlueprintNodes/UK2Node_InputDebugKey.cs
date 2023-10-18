namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_InputDebugKey.h")]
public partial class UK2Node_InputDebugKey : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>The key that is bound</summary>
	public FKey InputKey;
	///<summary>Should the binding execute even when the game is paused</summary>
	public bool bExecuteWhenPaused;
	///<summary>Does this binding require the control key on PC or the command key on Mac to be held</summary>
	public bool bControl;
	///<summary>Does this binding require the alt key to be held</summary>
	public bool bAlt;
	///<summary>Does this binding require the shift key to be held</summary>
	public bool bShift;
	///<summary>Does this binding require the windows key on PC or the control key on Mac to be held</summary>
	public bool bCommand;
}
