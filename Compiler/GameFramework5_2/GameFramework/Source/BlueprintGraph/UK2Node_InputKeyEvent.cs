namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_InputKeyEvent.h")]
public partial class UK2Node_InputKeyEvent : UK2Node_Event {
	public static UClass StaticClass() {return default;}
	///<summary>InputChord</summary>
	public FInputChord InputChord;
	///<summary>InputKeyEvent</summary>
	public EInputEvent InputKeyEvent;
	///<summary>bConsumeInput</summary>
	public bool bConsumeInput;
	///<summary>bExecuteWhenPaused</summary>
	public bool bExecuteWhenPaused;
	///<summary>bOverrideParentBinding</summary>
	public bool bOverrideParentBinding;
}
