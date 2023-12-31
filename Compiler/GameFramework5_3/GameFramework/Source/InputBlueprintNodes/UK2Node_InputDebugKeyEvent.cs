namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_InputDebugKeyEvent.h")]
public partial class UK2Node_InputDebugKeyEvent : UK2Node_Event {
	public static UClass StaticClass() {return default;}
	///<summary>InputChord</summary>
	public FInputChord InputChord;
	///<summary>InputKeyEvent</summary>
	public EInputEvent InputKeyEvent;
	///<summary>bExecuteWhenPaused</summary>
	public bool bExecuteWhenPaused;
}
