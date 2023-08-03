#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_InputKey.h")]
public partial class UK2Node_InputKey : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>The key that is bound</summary>
	public FKey InputKey;
	///<summary>Prevents actors with lower priority from handling this input</summary>
	public bool bConsumeInput;
	///<summary>Should the binding execute even when the game is paused</summary>
	public bool bExecuteWhenPaused;
	///<summary>Should any bindings to this event in parent classes be removed</summary>
	public bool bOverrideParentBinding;
	///<summary>Does this binding require the control key on PC or the command key on Mac to be held</summary>
	public bool bControl;
	///<summary>Does this binding require the alt key to be held</summary>
	public bool bAlt;
	///<summary>Does this binding require the shift key to be held</summary>
	public bool bShift;
	///<summary>Does this binding require the windows key on PC or the control key on Mac to be held</summary>
	public bool bCommand;
}
